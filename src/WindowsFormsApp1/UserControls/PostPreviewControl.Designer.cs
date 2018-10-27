namespace WindowsFormsApp1.UserControls
{
    partial class PostPreviewControl
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
            this.components = new System.ComponentModel.Container();
            this.ItemIndexLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NextItemButton = new System.Windows.Forms.Label();
            this.PreviousItemButton = new System.Windows.Forms.Label();
            this.ItemPagerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.PostTitleLabel = new System.Windows.Forms.Label();
            this.PostIdLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.PhotoCaptionLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.TagsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RebloggedFromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PostDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopiedPopup = new System.Windows.Forms.Label();
            this.CopiedPopupTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.ItemPagerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemIndexLabel
            // 
            this.ItemIndexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemIndexLabel.AutoSize = true;
            this.ItemIndexLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIndexLabel.Location = new System.Drawing.Point(39, 4);
            this.ItemIndexLabel.Name = "ItemIndexLabel";
            this.ItemIndexLabel.Size = new System.Drawing.Size(98, 21);
            this.ItemIndexLabel.TabIndex = 4;
            this.ItemIndexLabel.Text = "Photo 1 of 99";
            this.ItemIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.NextItemButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PreviousItemButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemIndexLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // NextItemButton
            // 
            this.NextItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextItemButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextItemButton.Image = global::WindowsFormsApp1.Properties.Resources.right_24;
            this.NextItemButton.Location = new System.Drawing.Point(143, 0);
            this.NextItemButton.Name = "NextItemButton";
            this.NextItemButton.Size = new System.Drawing.Size(30, 30);
            this.NextItemButton.TabIndex = 6;
            this.NextItemButton.Click += new System.EventHandler(this.NextItemButton_Click);
            // 
            // PreviousItemButton
            // 
            this.PreviousItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousItemButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousItemButton.Image = global::WindowsFormsApp1.Properties.Resources.left_24;
            this.PreviousItemButton.Location = new System.Drawing.Point(3, 0);
            this.PreviousItemButton.Name = "PreviousItemButton";
            this.PreviousItemButton.Size = new System.Drawing.Size(30, 30);
            this.PreviousItemButton.TabIndex = 5;
            this.PreviousItemButton.Click += new System.EventHandler(this.PreviousItemButton_Click);
            // 
            // ItemPagerPanel
            // 
            this.ItemPagerPanel.ColumnCount = 1;
            this.ItemPagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemPagerPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.ItemPagerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemPagerPanel.Location = new System.Drawing.Point(0, 526);
            this.ItemPagerPanel.Name = "ItemPagerPanel";
            this.ItemPagerPanel.RowCount = 1;
            this.ItemPagerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemPagerPanel.Size = new System.Drawing.Size(877, 53);
            this.ItemPagerPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.PostTitleLabel);
            this.panel1.Controls.Add(this.PostIdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.panel1.Size = new System.Drawing.Size(877, 65);
            this.panel1.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Image = global::WindowsFormsApp1.Properties.Resources.close_24;
            this.CloseButton.Location = new System.Drawing.Point(840, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PostTitleLabel
            // 
            this.PostTitleLabel.AutoSize = true;
            this.PostTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTitleLabel.Location = new System.Drawing.Point(4, 34);
            this.PostTitleLabel.Name = "PostTitleLabel";
            this.PostTitleLabel.Size = new System.Drawing.Size(37, 21);
            this.PostTitleLabel.TabIndex = 3;
            this.PostTitleLabel.Text = "Title";
            this.PostTitleLabel.Click += new System.EventHandler(this.PostTitleLabel_Click);
            // 
            // PostIdLabel
            // 
            this.PostIdLabel.AutoSize = true;
            this.PostIdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostIdLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostIdLabel.Location = new System.Drawing.Point(4, 4);
            this.PostIdLabel.Name = "PostIdLabel";
            this.PostIdLabel.Size = new System.Drawing.Size(121, 30);
            this.PostIdLabel.TabIndex = 1;
            this.PostIdLabel.Text = "Post 000000";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPictureBox.Location = new System.Drawing.Point(0, 65);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(677, 400);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 8;
            this.PhotoPictureBox.TabStop = false;
            this.PhotoPictureBox.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            // 
            // PhotoCaptionLabel
            // 
            this.PhotoCaptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PhotoCaptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.PhotoCaptionLabel.Location = new System.Drawing.Point(0, 465);
            this.PhotoCaptionLabel.Name = "PhotoCaptionLabel";
            this.PhotoCaptionLabel.Size = new System.Drawing.Size(877, 61);
            this.PhotoCaptionLabel.TabIndex = 10;
            this.PhotoCaptionLabel.Text = "Caption";
            this.PhotoCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhotoCaptionLabel.Visible = false;
            this.PhotoCaptionLabel.Click += new System.EventHandler(this.PhotoCaptionLabel_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.TagsListBox);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.RebloggedFromTextBox);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.PostDateTextBox);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(677, 65);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(200, 400);
            this.InfoPanel.TabIndex = 11;
            // 
            // TagsListBox
            // 
            this.TagsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TagsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagsListBox.ForeColor = System.Drawing.Color.White;
            this.TagsListBox.FormattingEnabled = true;
            this.TagsListBox.IntegralHeight = false;
            this.TagsListBox.Location = new System.Drawing.Point(11, 157);
            this.TagsListBox.Name = "TagsListBox";
            this.TagsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TagsListBox.Size = new System.Drawing.Size(182, 234);
            this.TagsListBox.TabIndex = 11;
            this.TagsListBox.SelectedIndexChanged += new System.EventHandler(this.TagsListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tags:";
            // 
            // RebloggedFromTextBox
            // 
            this.RebloggedFromTextBox.Location = new System.Drawing.Point(11, 107);
            this.RebloggedFromTextBox.Name = "RebloggedFromTextBox";
            this.RebloggedFromTextBox.ReadOnly = true;
            this.RebloggedFromTextBox.Size = new System.Drawing.Size(182, 22);
            this.RebloggedFromTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reblogged From:";
            // 
            // PostDateTextBox
            // 
            this.PostDateTextBox.Location = new System.Drawing.Point(11, 59);
            this.PostDateTextBox.Name = "PostDateTextBox";
            this.PostDateTextBox.ReadOnly = true;
            this.PostDateTextBox.Size = new System.Drawing.Size(182, 22);
            this.PostDateTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Post Details";
            // 
            // CopiedPopup
            // 
            this.CopiedPopup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopiedPopup.AutoSize = true;
            this.CopiedPopup.BackColor = System.Drawing.Color.DimGray;
            this.CopiedPopup.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiedPopup.Location = new System.Drawing.Point(336, 266);
            this.CopiedPopup.Name = "CopiedPopup";
            this.CopiedPopup.Padding = new System.Windows.Forms.Padding(8);
            this.CopiedPopup.Size = new System.Drawing.Size(205, 46);
            this.CopiedPopup.TabIndex = 14;
            this.CopiedPopup.Text = "Copied to clipboard";
            this.CopiedPopup.Visible = false;
            // 
            // CopiedPopupTimer
            // 
            this.CopiedPopupTimer.Interval = 2000;
            this.CopiedPopupTimer.Tick += new System.EventHandler(this.CopiedPopupTimer_Tick);
            // 
            // PostPreviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.CopiedPopup);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PhotoCaptionLabel);
            this.Controls.Add(this.ItemPagerPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PostPreviewControl";
            this.Size = new System.Drawing.Size(877, 579);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ItemPagerPanel.ResumeLayout(false);
            this.ItemPagerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ItemIndexLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PreviousItemButton;
        private System.Windows.Forms.Label NextItemButton;
        private System.Windows.Forms.TableLayoutPanel ItemPagerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label PostTitleLabel;
        private System.Windows.Forms.Label PostIdLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label PhotoCaptionLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox PostDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RebloggedFromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TagsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CopiedPopup;
        private System.Windows.Forms.Timer CopiedPopupTimer;
    }
}
