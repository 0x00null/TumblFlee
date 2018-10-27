namespace WindowsFormsApp1.UserControls
{
    partial class PostPreviewTileControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThumbnailPictureBox
            // 
            this.ThumbnailPictureBox.Location = new System.Drawing.Point(5, 5);
            this.ThumbnailPictureBox.Name = "ThumbnailPictureBox";
            this.ThumbnailPictureBox.Size = new System.Drawing.Size(150, 150);
            this.ThumbnailPictureBox.TabIndex = 0;
            this.ThumbnailPictureBox.TabStop = false;
            this.ThumbnailPictureBox.Click += new System.EventHandler(this.ThumbnailPictureBox_Click);
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.CaptionLabel.Location = new System.Drawing.Point(3, 158);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(152, 30);
            this.CaptionLabel.TabIndex = 1;
            this.CaptionLabel.Text = "Caption";
            this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CaptionLabel.Click += new System.EventHandler(this.CaptionLabel_Click);
            // 
            // PostPreviewTileControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.ThumbnailPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PostPreviewTileControl";
            this.Size = new System.Drawing.Size(160, 192);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ThumbnailPictureBox;
        private System.Windows.Forms.Label CaptionLabel;
    }
}
