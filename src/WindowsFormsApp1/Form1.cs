using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private RestClient _client;
        private Object _exportQueueLock = new Object();
        private Object _exportedPostsLock = new Object();

        /// <summary>
        /// The current blog
        /// </summary>
        public BlogInfo Blog { get; set; }

        /// <summary>
        /// Post metadata
        /// </summary>
        public PostCollection Posts { get; set; }

        /// <summary>
        /// Posts to export
        /// </summary>
        public Queue<PostInfo> ExportQueue { get; set; }

        /// <summary>
        /// The base path to export to
        /// </summary>
        public String ExportPath { get; set; }

        /// <summary>
        /// Exported Posts
        /// </summary>
        public List<ExportedPost> ExportedPosts { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ExportPathTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TumblFlee", "Exports");
            ExportPathDialog.SelectedPath = ExportPathTextBox.Text;
        }

        private async void OpenButton_Click(object sender, EventArgs e)
        {
            ConnectPanel.Enabled = false;

            // Fetch details on posts
            _client = new RestSharp.RestClient("http://api.tumblr.com/v2/");
            _client.DefaultParameters.Add(new RestSharp.Parameter("api_key", ApiKeyTextBox.Text, RestSharp.ParameterType.QueryString));
            _client.DefaultParameters.Add(new Parameter("blog", BlogNameTextBox.Text, ParameterType.UrlSegment));

            // Load details on the blog
            await LoadBlogMeta();
            ConnectPanel.Hide();

            // Load details on posts
            await LoadPostData();

            // Show the Export Settings panel
            ExportOptionsPanel.Show();
            ExportOptionsPanel.BringToFront();

            OriginalPhotoCheckBox.Text = Posts.PhotoPosts.Originals.Count().ToString();
            ReblogPhotoCheckBox.Text = Posts.PhotoPosts.Reblogs.Count().ToString();

        }

        private async Task LoadBlogMeta()
        {
            // Fetch blog info
            var info = await _client.CallApi<BlogInfoResponse>(new RestRequest("blog/{blog}/info", Method.GET));

            Blog = info.Blog;
            BlogTitleLabel.Text = Blog.Title;
            BlogDescriptionLabel.Text = Blog.Description;
            BlogTotalPostsLabel.Text = Blog.TotalPosts.ToString();

            // Load avatar
            var avatar = await _client.ExecuteTaskAsync(new RestRequest("blog/{blog}/avatar/512"));
            using (var pngStream = new MemoryStream(avatar.RawBytes))
            {
                BlogAvatarPicture.Image = Image.FromStream(pngStream);
            }

            BlogInfoPanel.Show();
            IndexPanel.Show();
            IndexPanel.BringToFront();
        }

        private async Task LoadPostData()
        {
            var currentOffset = 0;
            var pageSize = 50;
            var allPosts = new List<PostInfo>();
            LoadPostsProgressBar.Maximum = Blog.TotalPosts;

            while (currentOffset < Blog.TotalPosts)
            {
                // Fetch posts in this page
                var rateLimitTask = Task.Delay(500);

                var currentPage = await _client.CallApi<ListPostsResponse>(new RestRequest("blog/{blog}/posts")
                .AddParameter("offset", currentOffset, ParameterType.QueryString)
                .AddParameter("limit", pageSize, ParameterType.QueryString)
                .AddParameter("reblog_info", "true")
                .AddParameter("filter", "text"));

                allPosts.AddRange(currentPage.Posts);

                currentOffset += pageSize;
                LoadPostsProgressBar.Value = allPosts.Count;
                await rateLimitTask;
            }
            Posts = new PostCollection(allPosts);
            IndexPanel.Hide();
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            // Set the export location
            ExportPath = Path.Combine(ExportPathTextBox.Text, Blog.Name);

            // Ensure the export location exists
            if (Directory.Exists(ExportPath) == false)
            {
                Directory.CreateDirectory(ExportPath);
            }

            // Gather posts to export
            var postList = new List<PostInfo>();

            if (OriginalPhotoCheckBox.Checked)
                postList.AddRange(Posts.PhotoPosts.Originals);

            if (ReblogPhotoCheckBox.Checked)
                postList.AddRange(Posts.PhotoPosts.Reblogs);

            ExportQueue = new Queue<PostInfo>(postList);
            ExportedPosts = new List<ExportedPost>();

            ExportOptionsPanel.Hide();
            ExportProgressPanel.Show();
            ExportProgressPanel.BringToFront();

            ExportProgressBar.Maximum = ExportQueue.Count;
            ExportStatusLabel.Text = String.Format("Exporting {0} posts...", ExportQueue.Count);

            // Create 4 download threads
            await Task.WhenAll(
                OnProcessQueue(),
                OnProcessQueue(),
                OnProcessQueue(),
                OnProcessQueue()
            );

            // Save the index to index.json
            File.WriteAllText(Path.Combine(ExportPath, "index.json"), JsonConvert.SerializeObject(ExportedPosts));
            ExportProgressPanel.Hide();

            // Show the Finished panel
            ExportedPathLink.Text = ExportPath;
            FinishedPanel.Show();
            FinishedPanel.BringToFront();

            // Now reload the export and display
            var export = Export.Load(ExportPath);
            var fView = new ViewExportForm(export);
            fView.Show();
        }

        private async Task OnProcessQueue()
        {
            PostInfo post = null;
            HttpClient httpClient = new HttpClient();

            while (true)
            {
                lock (_exportQueueLock)
                {
                    if (ExportQueue.Any())
                    {
                        post = ExportQueue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }

                // Process the post
                var exportedPost = new ExportedPost()
                {
                    Id = post.Id,
                    RebloggedFrom = post.RebloggedFrom,
                    Date = post.Timestamp,
                    Tags = post.Tags,
                    OriginalUrl = post.FullUrl
                };

                switch (post.Type)
                {
                    case "photo":

                        var photoData = post.AsPhoto();
                        exportedPost.Caption = photoData.Caption;

                        var index = 1;
                        foreach (var photo in photoData.Photos)
                        {
                            var mediaItem = new ExportedMediaItem()
                            {
                                Filename = string.Format("{0}-{1}.jpg", post.Id, index),
                                Caption = photo.Caption
                            };

                            // Now grab the biggest alt_size we can find
                            var largest = photo.Sizes.OrderByDescending(s => s.Width).First();
                            var targetlocalFile = Path.Combine(ExportPath, mediaItem.Filename);
                            // Ensure the file doesnt already exist
                            if (!File.Exists(targetlocalFile))
                            {
                                // File does not exist - download it
                                using (var jpegStream = await httpClient.GetStreamAsync(largest.Url))
                                using (var exportStream = File.Create(Path.Combine(ExportPath, mediaItem.Filename)))
                                {
                                    await jpegStream.CopyToAsync(exportStream);
                                    await exportStream.FlushAsync();
                                }
                            }
                            exportedPost.Photos.Add(mediaItem);
                            index++;
                        }
                        break;

                    default:
                        break;
                }

                lock(_exportedPostsLock)
                {
                    ExportedPosts.Add(exportedPost);
                }

                ExportProgressBar.Value++;
            }
        }

        private void OpenPreviousExportButton_Click(object sender, EventArgs e)
        {
            if (ExportPathDialog.ShowDialog() != DialogResult.OK)
                return;

            var export = Export.Load(ExportPathDialog.SelectedPath);
            var fView = new ViewExportForm(export);
            fView.Show();
        }

        private void BrowseExportLocationButton_Click(object sender, EventArgs e)
        {
            if (ExportPathDialog.ShowDialog() != DialogResult.OK)
                return;

            ExportPathTextBox.Text = ExportPathDialog.SelectedPath;
        }
    }
}
