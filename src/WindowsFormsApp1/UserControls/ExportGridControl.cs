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

namespace WindowsFormsApp1.UserControls
{
    public partial class ExportGridControl : UserControl
    {
        private Export _export;
        private IEnumerable<ExportedPost> _currentResults;

        public ExportGridControl()
        {
            InitializeComponent();
            MainPanel.SendToBack();
            PreviewControl.BringToFront();
            PreviewControl.Dock = DockStyle.Fill;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Export Export
        {
            get { return _export; }
            set
            {
                _export = value;
                OnExportChanged();
            }
        }

        private void OnExportChanged()
        {
            PreviewControl.Export = Export;

            // Build the tags list
            TagsList.Items.Clear();
            var tagItems = Export.Posts
                .SelectMany(p => p.Tags)
                .Distinct()
                .Select(tag => new TagListItem()
                {
                    Tag = tag,
                    TotalPosts = Export.Posts.Count(p => p.Tags.Contains(tag))
                })
                .OrderByDescending(x => x.TotalPosts);


            TagsList.Items.AddRange(tagItems.ToArray());

            ApplySortAndFilter();
        }

        private void CollapseFiltersButton_Click(object sender, EventArgs e)
        {
            FilterPanel.Hide();
        }

        private void FiltersButton_Click(object sender, EventArgs e)
        {
            FilterPanel.Show();
        }

        private void ApplySortAndFilter()
        {
            _currentResults = _export.Posts;

            var checkedTags = TagsList.CheckedItems.Cast<TagListItem>().Select(t => t.Tag);
            if (checkedTags.Any())
            {
                _currentResults = _currentResults.Where(r => r.Tags.Intersect(checkedTags).Any());
            }

            if (SortNewestRadio.Checked)
            {
                _currentResults = _currentResults.OrderByDescending(p => p.Date);
            }
            else
            {
                _currentResults = _currentResults.OrderBy(p => p.Date);
            }

            

            RefreshTiles();
        }

        /// <summary>
        /// Refreshes visible tiles based on the current view
        /// </summary>
        private void RefreshTiles()
        {
            TilesPanel.Hide();
            TilesPanel.SuspendLayout();
            var tilesToDispose = TilesPanel.Controls.Cast<PostPreviewTileControl>().ToArray();
            TilesPanel.Controls.Clear();
            foreach (var tile in tilesToDispose)
            {
                tile.Click -= Tile_Click;
                tile.Dispose();
            }

            // Now create new tiles
            foreach (var post in _currentResults)
            {
                var tileControl = new PostPreviewTileControl();
                TilesPanel.Controls.Add(tileControl);
                tileControl.Export = _export;
                tileControl.Post = post;
                tileControl.Click += Tile_Click;
            }


            TilesPanel.ResumeLayout(true);
            TilesPanel.Show();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            FilterPanel.Hide();
            var post = (sender as PostPreviewTileControl).Post;
            PreviewControl.Post = post;
            PreviewControl.Show();
        }

        private void PreviewControl_CloseRequested(object sender, EventArgs e)
        {
            PreviewControl.Hide();
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            FilterPanel.Hide();
            ApplySortAndFilter();
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            TagsList.CheckedIndices.Cast<Int32>().ToList().ForEach(i => TagsList.SetItemChecked(i, false));
            ApplySortAndFilter();
        }

        private void Sort_Changed(object sender, EventArgs e)
        {
            ApplySortAndFilter();
        }
    }
}
