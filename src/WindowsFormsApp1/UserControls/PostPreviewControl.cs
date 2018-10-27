using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using System.IO;

namespace WindowsFormsApp1.UserControls
{
    public partial class PostPreviewControl : UserControl
    {
        public Export Export { get; set; }

        public event EventHandler CloseRequested;

        private ExportedPost _post;
        private Int32 _photoIndex = 0;

        public ExportedPost Post
        {
            get { return _post; }
            set
            {
                _post = value;
                OnPostChanged();
            }
        }

        public PostPreviewControl()
        {
            InitializeComponent();
        }

        private void OnPostChanged()
        {
            if (Post == null)
                return;

            PostIdLabel.Text = String.Format("Post {0}", Post.Id);
            PostTitleLabel.Text = Post.Caption;
            PostDateTextBox.Text = Post.Date.ToString("yyyy-MM-dd HH:mm");
            RebloggedFromTextBox.Text = Post.RebloggedFrom;
            TagsListBox.Items.Clear();
            TagsListBox.Items.AddRange(Post.Tags.ToArray());


            _photoIndex = -1;
            NextPhoto();
        }

        private void NextPhoto()
        {
            _photoIndex++;

            if (_photoIndex == Post.Photos.Count)
                _photoIndex = 0;

            ShowCurrentPhoto();
        }

        private void PrevPhoto()
        {
            _photoIndex--;

            if (_photoIndex == -1)
                _photoIndex = Post.Photos.Count - 1;

            ShowCurrentPhoto();
        }

        private void ShowCurrentPhoto()
        {
            var currentPhoto = Post.Photos[_photoIndex];
            PhotoPictureBox.ImageLocation = Path.Combine(Export.BasePath, currentPhoto.Filename);
            if (string.IsNullOrEmpty(currentPhoto.Caption))
            {
                PhotoCaptionLabel.Hide();
            }
            else
            {
                PhotoCaptionLabel.Text = currentPhoto.Caption;
                PhotoCaptionLabel.Show();
            }

            ItemIndexLabel.Text = String.Format("Photo {0} of {1}", _photoIndex + 1, Post.Photos.Count);
        }

        private void NextItemButton_Click(object sender, EventArgs e)
        {
            NextPhoto();
        }

        private void PreviousItemButton_Click(object sender, EventArgs e)
        {
            PrevPhoto();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (CloseRequested != null)
                CloseRequested(this, EventArgs.Empty);
        }

        private void CopiedPopupTimer_Tick(object sender, EventArgs e)
        {
            CopiedPopupTimer.Stop();
            CopiedPopup.Hide();
        }

        private void PostTitleLabel_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(PostTitleLabel.Text);
            NotifyCopied();
        }

        private void NotifyCopied()
        {
            CopiedPopup.Show();
            CopiedPopupTimer.Stop();
            CopiedPopupTimer.Start();
        }

        private void PhotoCaptionLabel_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(PhotoCaptionLabel.Text);
            NotifyCopied();
        }

        private void TagsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(String.Join(" ", Post.Tags.Select(t => "#" + t)));
            NotifyCopied();
        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(PhotoPictureBox.Image);
            NotifyCopied();
        }
    }
}
