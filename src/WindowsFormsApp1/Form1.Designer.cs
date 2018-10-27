namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.BlogNameTextBox = new System.Windows.Forms.TextBox();
            this.ApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadPostsProgressBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectPanel = new System.Windows.Forms.Panel();
            this.IndexPanel = new System.Windows.Forms.Panel();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.FinishedPanel = new System.Windows.Forms.Panel();
            this.ExportedPathLink = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExportProgressPanel = new System.Windows.Forms.Panel();
            this.ExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExportStatusLabel = new System.Windows.Forms.Label();
            this.ExportOptionsPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BrowseExportLocationButton = new System.Windows.Forms.Button();
            this.ExportPathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportGridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReblogPhotoCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginalPhotoCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BlogInfoPanel = new System.Windows.Forms.Panel();
            this.BlogTotalPostsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BlogDescriptionLabel = new System.Windows.Forms.Label();
            this.BlogTitleLabel = new System.Windows.Forms.Label();
            this.BlogAvatarPicture = new System.Windows.Forms.PictureBox();
            this.ExportPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenPreviousExportButton = new System.Windows.Forms.Button();
            this.ConnectPanel.SuspendLayout();
            this.IndexPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            this.FinishedPanel.SuspendLayout();
            this.ExportProgressPanel.SuspendLayout();
            this.ExportOptionsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ExportGridPanel.SuspendLayout();
            this.BlogInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlogAvatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(611, 37);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 22);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // BlogNameTextBox
            // 
            this.BlogNameTextBox.Location = new System.Drawing.Point(7, 37);
            this.BlogNameTextBox.Name = "BlogNameTextBox";
            this.BlogNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.BlogNameTextBox.TabIndex = 1;
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiKeyTextBox.Location = new System.Drawing.Point(273, 37);
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.Size = new System.Drawing.Size(332, 22);
            this.ApiKeyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "TumblFlee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A tool to flee tumblr with your images and metadata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL of the tumblr blog to export:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "API Key to use when exporting:";
            // 
            // LoadPostsProgressBar
            // 
            this.LoadPostsProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadPostsProgressBar.Location = new System.Drawing.Point(0, 13);
            this.LoadPostsProgressBar.Name = "LoadPostsProgressBar";
            this.LoadPostsProgressBar.Size = new System.Drawing.Size(685, 8);
            this.LoadPostsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadPostsProgressBar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Loading Posts...";
            // 
            // ConnectPanel
            // 
            this.ConnectPanel.Controls.Add(this.label3);
            this.ConnectPanel.Controls.Add(this.ConnectButton);
            this.ConnectPanel.Controls.Add(this.BlogNameTextBox);
            this.ConnectPanel.Controls.Add(this.ApiKeyTextBox);
            this.ConnectPanel.Controls.Add(this.label4);
            this.ConnectPanel.Controls.Add(this.label5);
            this.ConnectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectPanel.Location = new System.Drawing.Point(0, 0);
            this.ConnectPanel.Name = "ConnectPanel";
            this.ConnectPanel.Size = new System.Drawing.Size(689, 67);
            this.ConnectPanel.TabIndex = 13;
            // 
            // IndexPanel
            // 
            this.IndexPanel.AutoSize = true;
            this.IndexPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IndexPanel.Controls.Add(this.LoadPostsProgressBar);
            this.IndexPanel.Controls.Add(this.label7);
            this.IndexPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IndexPanel.Location = new System.Drawing.Point(0, 149);
            this.IndexPanel.Name = "IndexPanel";
            this.IndexPanel.Size = new System.Drawing.Size(689, 24);
            this.IndexPanel.TabIndex = 14;
            this.IndexPanel.Visible = false;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.FinishedPanel);
            this.MainContentPanel.Controls.Add(this.ExportProgressPanel);
            this.MainContentPanel.Controls.Add(this.ExportOptionsPanel);
            this.MainContentPanel.Controls.Add(this.IndexPanel);
            this.MainContentPanel.Controls.Add(this.BlogInfoPanel);
            this.MainContentPanel.Controls.Add(this.ConnectPanel);
            this.MainContentPanel.Location = new System.Drawing.Point(12, 56);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(689, 489);
            this.MainContentPanel.TabIndex = 15;
            // 
            // FinishedPanel
            // 
            this.FinishedPanel.Controls.Add(this.ExportedPathLink);
            this.FinishedPanel.Controls.Add(this.label8);
            this.FinishedPanel.Controls.Add(this.label6);
            this.FinishedPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinishedPanel.Location = new System.Drawing.Point(0, 385);
            this.FinishedPanel.Name = "FinishedPanel";
            this.FinishedPanel.Size = new System.Drawing.Size(689, 58);
            this.FinishedPanel.TabIndex = 17;
            this.FinishedPanel.Visible = false;
            // 
            // ExportedPathLink
            // 
            this.ExportedPathLink.AutoSize = true;
            this.ExportedPathLink.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.ExportedPathLink.Location = new System.Drawing.Point(4, 37);
            this.ExportedPathLink.Name = "ExportedPathLink";
            this.ExportedPathLink.Size = new System.Drawing.Size(78, 13);
            this.ExportedPathLink.TabIndex = 39;
            this.ExportedPathLink.TabStop = true;
            this.ExportedPathLink.Text = "c:\\somewhere";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "The selected posts have been exported to the following folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Export Complete ^_^";
            // 
            // ExportProgressPanel
            // 
            this.ExportProgressPanel.AutoSize = true;
            this.ExportProgressPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportProgressPanel.Controls.Add(this.ExportProgressBar);
            this.ExportProgressPanel.Controls.Add(this.ExportStatusLabel);
            this.ExportProgressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportProgressPanel.Location = new System.Drawing.Point(0, 361);
            this.ExportProgressPanel.Name = "ExportProgressPanel";
            this.ExportProgressPanel.Size = new System.Drawing.Size(689, 24);
            this.ExportProgressPanel.TabIndex = 40;
            this.ExportProgressPanel.Visible = false;
            // 
            // ExportProgressBar
            // 
            this.ExportProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportProgressBar.Location = new System.Drawing.Point(0, 13);
            this.ExportProgressBar.Name = "ExportProgressBar";
            this.ExportProgressBar.Size = new System.Drawing.Size(685, 8);
            this.ExportProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ExportProgressBar.TabIndex = 8;
            // 
            // ExportStatusLabel
            // 
            this.ExportStatusLabel.AutoSize = true;
            this.ExportStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.ExportStatusLabel.Name = "ExportStatusLabel";
            this.ExportStatusLabel.Size = new System.Drawing.Size(111, 13);
            this.ExportStatusLabel.TabIndex = 10;
            this.ExportStatusLabel.Text = "Exporting {0} Posts...";
            // 
            // ExportOptionsPanel
            // 
            this.ExportOptionsPanel.AutoSize = true;
            this.ExportOptionsPanel.Controls.Add(this.panel3);
            this.ExportOptionsPanel.Controls.Add(this.ExportGridPanel);
            this.ExportOptionsPanel.Controls.Add(this.label19);
            this.ExportOptionsPanel.Controls.Add(this.label14);
            this.ExportOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportOptionsPanel.Location = new System.Drawing.Point(0, 173);
            this.ExportOptionsPanel.Name = "ExportOptionsPanel";
            this.ExportOptionsPanel.Size = new System.Drawing.Size(689, 188);
            this.ExportOptionsPanel.TabIndex = 42;
            this.ExportOptionsPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BrowseExportLocationButton);
            this.panel3.Controls.Add(this.ExportPathTextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ExportButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 35);
            this.panel3.TabIndex = 41;
            // 
            // BrowseExportLocationButton
            // 
            this.BrowseExportLocationButton.Location = new System.Drawing.Point(316, 6);
            this.BrowseExportLocationButton.Name = "BrowseExportLocationButton";
            this.BrowseExportLocationButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseExportLocationButton.TabIndex = 42;
            this.BrowseExportLocationButton.Text = "Browse";
            this.BrowseExportLocationButton.UseVisualStyleBackColor = true;
            this.BrowseExportLocationButton.Click += new System.EventHandler(this.BrowseExportLocationButton_Click);
            // 
            // ExportPathTextBox
            // 
            this.ExportPathTextBox.Location = new System.Drawing.Point(67, 6);
            this.ExportPathTextBox.Name = "ExportPathTextBox";
            this.ExportPathTextBox.ReadOnly = true;
            this.ExportPathTextBox.Size = new System.Drawing.Size(243, 22);
            this.ExportPathTextBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Export To:";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(610, 6);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 39;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportGridPanel
            // 
            this.ExportGridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportGridPanel.ColumnCount = 3;
            this.ExportGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExportGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExportGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExportGridPanel.Controls.Add(this.ReblogPhotoCheckBox, 1, 2);
            this.ExportGridPanel.Controls.Add(this.OriginalPhotoCheckBox, 1, 1);
            this.ExportGridPanel.Controls.Add(this.label13, 0, 1);
            this.ExportGridPanel.Controls.Add(this.label21, 0, 2);
            this.ExportGridPanel.Controls.Add(this.label18, 1, 0);
            this.ExportGridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportGridPanel.Location = new System.Drawing.Point(0, 26);
            this.ExportGridPanel.Name = "ExportGridPanel";
            this.ExportGridPanel.RowCount = 3;
            this.ExportGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExportGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExportGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExportGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ExportGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ExportGridPanel.Size = new System.Drawing.Size(689, 127);
            this.ExportGridPanel.TabIndex = 39;
            // 
            // ReblogPhotoCheckBox
            // 
            this.ReblogPhotoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReblogPhotoCheckBox.AutoSize = true;
            this.ReblogPhotoCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReblogPhotoCheckBox.Location = new System.Drawing.Point(106, 73);
            this.ReblogPhotoCheckBox.Name = "ReblogPhotoCheckBox";
            this.ReblogPhotoCheckBox.Size = new System.Drawing.Size(41, 29);
            this.ReblogPhotoCheckBox.TabIndex = 36;
            this.ReblogPhotoCheckBox.Text = "0";
            this.ReblogPhotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // OriginalPhotoCheckBox
            // 
            this.OriginalPhotoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OriginalPhotoCheckBox.AutoSize = true;
            this.OriginalPhotoCheckBox.Checked = true;
            this.OriginalPhotoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OriginalPhotoCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPhotoCheckBox.Location = new System.Drawing.Point(106, 16);
            this.OriginalPhotoCheckBox.Name = "OriginalPhotoCheckBox";
            this.OriginalPhotoCheckBox.Size = new System.Drawing.Size(41, 29);
            this.OriginalPhotoCheckBox.TabIndex = 36;
            this.OriginalPhotoCheckBox.Text = "0";
            this.OriginalPhotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Original Content:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Reblogs:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Photo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(0, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(265, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "We\'re only showing the post types supported for export";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Choose which posts you want to export:";
            // 
            // BlogInfoPanel
            // 
            this.BlogInfoPanel.AutoSize = true;
            this.BlogInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BlogInfoPanel.Controls.Add(this.BlogTotalPostsLabel);
            this.BlogInfoPanel.Controls.Add(this.label10);
            this.BlogInfoPanel.Controls.Add(this.BlogDescriptionLabel);
            this.BlogInfoPanel.Controls.Add(this.BlogTitleLabel);
            this.BlogInfoPanel.Controls.Add(this.BlogAvatarPicture);
            this.BlogInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlogInfoPanel.Location = new System.Drawing.Point(0, 67);
            this.BlogInfoPanel.Name = "BlogInfoPanel";
            this.BlogInfoPanel.Size = new System.Drawing.Size(689, 82);
            this.BlogInfoPanel.TabIndex = 16;
            this.BlogInfoPanel.Visible = false;
            // 
            // BlogTotalPostsLabel
            // 
            this.BlogTotalPostsLabel.AutoSize = true;
            this.BlogTotalPostsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlogTotalPostsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlogTotalPostsLabel.Location = new System.Drawing.Point(83, 57);
            this.BlogTotalPostsLabel.Name = "BlogTotalPostsLabel";
            this.BlogTotalPostsLabel.Size = new System.Drawing.Size(22, 25);
            this.BlogTotalPostsLabel.TabIndex = 22;
            this.BlogTotalPostsLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(83, 38);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Posts:";
            // 
            // BlogDescriptionLabel
            // 
            this.BlogDescriptionLabel.AutoSize = true;
            this.BlogDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlogDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlogDescriptionLabel.Location = new System.Drawing.Point(83, 21);
            this.BlogDescriptionLabel.Name = "BlogDescriptionLabel";
            this.BlogDescriptionLabel.Size = new System.Drawing.Size(68, 17);
            this.BlogDescriptionLabel.TabIndex = 20;
            this.BlogDescriptionLabel.Text = "Description";
            // 
            // BlogTitleLabel
            // 
            this.BlogTitleLabel.AutoSize = true;
            this.BlogTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlogTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlogTitleLabel.Location = new System.Drawing.Point(83, 0);
            this.BlogTitleLabel.Name = "BlogTitleLabel";
            this.BlogTitleLabel.Size = new System.Drawing.Size(42, 21);
            this.BlogTitleLabel.TabIndex = 19;
            this.BlogTitleLabel.Text = "Title";
            // 
            // BlogAvatarPicture
            // 
            this.BlogAvatarPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlogAvatarPicture.Location = new System.Drawing.Point(0, 0);
            this.BlogAvatarPicture.Name = "BlogAvatarPicture";
            this.BlogAvatarPicture.Size = new System.Drawing.Size(83, 82);
            this.BlogAvatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlogAvatarPicture.TabIndex = 18;
            this.BlogAvatarPicture.TabStop = false;
            // 
            // OpenPreviousExportButton
            // 
            this.OpenPreviousExportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenPreviousExportButton.Location = new System.Drawing.Point(568, 18);
            this.OpenPreviousExportButton.Name = "OpenPreviousExportButton";
            this.OpenPreviousExportButton.Size = new System.Drawing.Size(133, 23);
            this.OpenPreviousExportButton.TabIndex = 41;
            this.OpenPreviousExportButton.Text = "View a previous Export";
            this.OpenPreviousExportButton.UseVisualStyleBackColor = true;
            this.OpenPreviousExportButton.Click += new System.EventHandler(this.OpenPreviousExportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(712, 557);
            this.Controls.Add(this.OpenPreviousExportButton);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "TumblFlee";
            this.ConnectPanel.ResumeLayout(false);
            this.ConnectPanel.PerformLayout();
            this.IndexPanel.ResumeLayout(false);
            this.IndexPanel.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            this.MainContentPanel.PerformLayout();
            this.FinishedPanel.ResumeLayout(false);
            this.FinishedPanel.PerformLayout();
            this.ExportProgressPanel.ResumeLayout(false);
            this.ExportProgressPanel.PerformLayout();
            this.ExportOptionsPanel.ResumeLayout(false);
            this.ExportOptionsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ExportGridPanel.ResumeLayout(false);
            this.ExportGridPanel.PerformLayout();
            this.BlogInfoPanel.ResumeLayout(false);
            this.BlogInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlogAvatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox BlogNameTextBox;
        private System.Windows.Forms.TextBox ApiKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar LoadPostsProgressBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ConnectPanel;
        private System.Windows.Forms.Panel IndexPanel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel BlogInfoPanel;
        private System.Windows.Forms.TableLayoutPanel ExportGridPanel;
        private System.Windows.Forms.CheckBox ReblogPhotoCheckBox;
        private System.Windows.Forms.CheckBox OriginalPhotoCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Panel ExportProgressPanel;
        private System.Windows.Forms.ProgressBar ExportProgressBar;
        private System.Windows.Forms.Label ExportStatusLabel;
        private System.Windows.Forms.FolderBrowserDialog ExportPathDialog;
        private System.Windows.Forms.Panel FinishedPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenPreviousExportButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BrowseExportLocationButton;
        private System.Windows.Forms.TextBox ExportPathTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel ExportOptionsPanel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel ExportedPathLink;
        private System.Windows.Forms.Label BlogTotalPostsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label BlogDescriptionLabel;
        private System.Windows.Forms.Label BlogTitleLabel;
        private System.Windows.Forms.PictureBox BlogAvatarPicture;
    }
}

