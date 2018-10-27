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
    public partial class PostPreviewTileControl : UserControl
    {
        private ExportedPost _post;
        private Export _export;

        public Export Export
        {
            get { return _export; }
            set { _export = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ExportedPost Post
        {
            get { return _post; }
            set { _post = value;
                OnPostChanged();
            }
        }

        private async Task OnPostChanged()
        {
            if (Post == null)
                return;

            var thumbImage = await ThumbnailHelper.GetThumbnail(_export, _post);
            ThumbnailPictureBox.Image = thumbImage;

            CaptionLabel.Text = Post.Caption;
        }

        public PostPreviewTileControl()
        {
            InitializeComponent();
        }

        private void ThumbnailPictureBox_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        private void CaptionLabel_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
