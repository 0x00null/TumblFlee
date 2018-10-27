namespace WindowsFormsApp1.UserControls
{
    partial class ExportGridControl
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
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.CollapseFiltersButton = new System.Windows.Forms.Label();
            this.TagsList = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PreviewControl = new WindowsFormsApp1.UserControls.PostPreviewControl();
            this.TilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.postPreviewTileControl1 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl2 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl3 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl4 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl5 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl6 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl7 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl8 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl9 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl10 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl11 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.postPreviewTileControl12 = new WindowsFormsApp1.UserControls.PostPreviewTileControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SortNewestRadio = new System.Windows.Forms.RadioButton();
            this.SortOldestRadio = new System.Windows.Forms.RadioButton();
            this.SortMostNotesRadio = new System.Windows.Forms.RadioButton();
            this.SortFewestNotesRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.FiltersButton = new System.Windows.Forms.Label();
            this.FilterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TilesPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FilterPanel.Controls.Add(this.CollapseFiltersButton);
            this.FilterPanel.Controls.Add(this.TagsList);
            this.FilterPanel.Controls.Add(this.panel1);
            this.FilterPanel.Controls.Add(this.label2);
            this.FilterPanel.Controls.Add(this.label1);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilterPanel.Location = new System.Drawing.Point(756, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Padding = new System.Windows.Forms.Padding(4);
            this.FilterPanel.Size = new System.Drawing.Size(235, 552);
            this.FilterPanel.TabIndex = 0;
            this.FilterPanel.Visible = false;
            // 
            // CollapseFiltersButton
            // 
            this.CollapseFiltersButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollapseFiltersButton.Image = global::WindowsFormsApp1.Properties.Resources.back_24;
            this.CollapseFiltersButton.Location = new System.Drawing.Point(4, 4);
            this.CollapseFiltersButton.Name = "CollapseFiltersButton";
            this.CollapseFiltersButton.Size = new System.Drawing.Size(30, 30);
            this.CollapseFiltersButton.TabIndex = 2;
            this.CollapseFiltersButton.Click += new System.EventHandler(this.CollapseFiltersButton_Click);
            // 
            // TagsList
            // 
            this.TagsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TagsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagsList.CheckOnClick = true;
            this.TagsList.ForeColor = System.Drawing.Color.White;
            this.TagsList.FormattingEnabled = true;
            this.TagsList.IntegralHeight = false;
            this.TagsList.Location = new System.Drawing.Point(15, 60);
            this.TagsList.Name = "TagsList";
            this.TagsList.ScrollAlwaysVisible = true;
            this.TagsList.Size = new System.Drawing.Size(219, 452);
            this.TagsList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearFilterButton);
            this.panel1.Controls.Add(this.ApplyFilterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 35);
            this.panel1.TabIndex = 4;
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClearFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClearFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClearFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFilterButton.Location = new System.Drawing.Point(19, 5);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(89, 26);
            this.ClearFilterButton.TabIndex = 1;
            this.ClearFilterButton.Text = "Clear";
            this.ClearFilterButton.UseVisualStyleBackColor = false;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ApplyFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ApplyFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ApplyFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ApplyFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilterButton.Location = new System.Drawing.Point(119, 5);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(89, 26);
            this.ApplyFilterButton.TabIndex = 0;
            this.ApplyFilterButton.Text = "Apply";
            this.ApplyFilterButton.UseVisualStyleBackColor = false;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tags:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PreviewControl);
            this.MainPanel.Controls.Add(this.TilesPanel);
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.FiltersButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(756, 552);
            this.MainPanel.TabIndex = 1;
            // 
            // PreviewControl
            // 
            this.PreviewControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.PreviewControl.Export = null;
            this.PreviewControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewControl.ForeColor = System.Drawing.Color.White;
            this.PreviewControl.Location = new System.Drawing.Point(164, 389);
            this.PreviewControl.Name = "PreviewControl";
            this.PreviewControl.Post = null;
            this.PreviewControl.Size = new System.Drawing.Size(427, 159);
            this.PreviewControl.TabIndex = 9;
            this.PreviewControl.Visible = false;
            this.PreviewControl.CloseRequested += new System.EventHandler(this.PreviewControl_CloseRequested);
            // 
            // TilesPanel
            // 
            this.TilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TilesPanel.AutoScroll = true;
            this.TilesPanel.Controls.Add(this.postPreviewTileControl1);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl2);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl3);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl4);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl5);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl6);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl7);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl8);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl9);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl10);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl11);
            this.TilesPanel.Controls.Add(this.postPreviewTileControl12);
            this.TilesPanel.Location = new System.Drawing.Point(8, 39);
            this.TilesPanel.Name = "TilesPanel";
            this.TilesPanel.Size = new System.Drawing.Size(745, 510);
            this.TilesPanel.TabIndex = 8;
            // 
            // postPreviewTileControl1
            // 
            this.postPreviewTileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl1.Export = null;
            this.postPreviewTileControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl1.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl1.Location = new System.Drawing.Point(3, 3);
            this.postPreviewTileControl1.Name = "postPreviewTileControl1";
            this.postPreviewTileControl1.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl1.TabIndex = 0;
            // 
            // postPreviewTileControl2
            // 
            this.postPreviewTileControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl2.Export = null;
            this.postPreviewTileControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl2.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl2.Location = new System.Drawing.Point(169, 3);
            this.postPreviewTileControl2.Name = "postPreviewTileControl2";
            this.postPreviewTileControl2.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl2.TabIndex = 1;
            // 
            // postPreviewTileControl3
            // 
            this.postPreviewTileControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl3.Export = null;
            this.postPreviewTileControl3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl3.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl3.Location = new System.Drawing.Point(335, 3);
            this.postPreviewTileControl3.Name = "postPreviewTileControl3";
            this.postPreviewTileControl3.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl3.TabIndex = 2;
            // 
            // postPreviewTileControl4
            // 
            this.postPreviewTileControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl4.Export = null;
            this.postPreviewTileControl4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl4.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl4.Location = new System.Drawing.Point(501, 3);
            this.postPreviewTileControl4.Name = "postPreviewTileControl4";
            this.postPreviewTileControl4.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl4.TabIndex = 3;
            // 
            // postPreviewTileControl5
            // 
            this.postPreviewTileControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl5.Export = null;
            this.postPreviewTileControl5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl5.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl5.Location = new System.Drawing.Point(3, 201);
            this.postPreviewTileControl5.Name = "postPreviewTileControl5";
            this.postPreviewTileControl5.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl5.TabIndex = 4;
            // 
            // postPreviewTileControl6
            // 
            this.postPreviewTileControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl6.Export = null;
            this.postPreviewTileControl6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl6.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl6.Location = new System.Drawing.Point(169, 201);
            this.postPreviewTileControl6.Name = "postPreviewTileControl6";
            this.postPreviewTileControl6.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl6.TabIndex = 5;
            // 
            // postPreviewTileControl7
            // 
            this.postPreviewTileControl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl7.Export = null;
            this.postPreviewTileControl7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl7.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl7.Location = new System.Drawing.Point(335, 201);
            this.postPreviewTileControl7.Name = "postPreviewTileControl7";
            this.postPreviewTileControl7.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl7.TabIndex = 6;
            // 
            // postPreviewTileControl8
            // 
            this.postPreviewTileControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl8.Export = null;
            this.postPreviewTileControl8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl8.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl8.Location = new System.Drawing.Point(501, 201);
            this.postPreviewTileControl8.Name = "postPreviewTileControl8";
            this.postPreviewTileControl8.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl8.TabIndex = 7;
            // 
            // postPreviewTileControl9
            // 
            this.postPreviewTileControl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl9.Export = null;
            this.postPreviewTileControl9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl9.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl9.Location = new System.Drawing.Point(3, 399);
            this.postPreviewTileControl9.Name = "postPreviewTileControl9";
            this.postPreviewTileControl9.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl9.TabIndex = 8;
            // 
            // postPreviewTileControl10
            // 
            this.postPreviewTileControl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl10.Export = null;
            this.postPreviewTileControl10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl10.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl10.Location = new System.Drawing.Point(169, 399);
            this.postPreviewTileControl10.Name = "postPreviewTileControl10";
            this.postPreviewTileControl10.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl10.TabIndex = 9;
            // 
            // postPreviewTileControl11
            // 
            this.postPreviewTileControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl11.Export = null;
            this.postPreviewTileControl11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl11.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl11.Location = new System.Drawing.Point(335, 399);
            this.postPreviewTileControl11.Name = "postPreviewTileControl11";
            this.postPreviewTileControl11.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl11.TabIndex = 10;
            // 
            // postPreviewTileControl12
            // 
            this.postPreviewTileControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.postPreviewTileControl12.Export = null;
            this.postPreviewTileControl12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPreviewTileControl12.ForeColor = System.Drawing.Color.White;
            this.postPreviewTileControl12.Location = new System.Drawing.Point(501, 399);
            this.postPreviewTileControl12.Name = "postPreviewTileControl12";
            this.postPreviewTileControl12.Size = new System.Drawing.Size(160, 192);
            this.postPreviewTileControl12.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.SortNewestRadio);
            this.flowLayoutPanel1.Controls.Add(this.SortOldestRadio);
            this.flowLayoutPanel1.Controls.Add(this.SortMostNotesRadio);
            this.flowLayoutPanel1.Controls.Add(this.SortFewestNotesRadio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 25);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // SortNewestRadio
            // 
            this.SortNewestRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortNewestRadio.AutoSize = true;
            this.SortNewestRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SortNewestRadio.Checked = true;
            this.SortNewestRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortNewestRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortNewestRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortNewestRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortNewestRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortNewestRadio.Location = new System.Drawing.Point(0, 0);
            this.SortNewestRadio.Margin = new System.Windows.Forms.Padding(0);
            this.SortNewestRadio.Name = "SortNewestRadio";
            this.SortNewestRadio.Size = new System.Drawing.Size(57, 25);
            this.SortNewestRadio.TabIndex = 4;
            this.SortNewestRadio.TabStop = true;
            this.SortNewestRadio.Text = "Newest";
            this.SortNewestRadio.UseVisualStyleBackColor = false;
            this.SortNewestRadio.CheckedChanged += new System.EventHandler(this.Sort_Changed);
            // 
            // SortOldestRadio
            // 
            this.SortOldestRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortOldestRadio.AutoSize = true;
            this.SortOldestRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SortOldestRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortOldestRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortOldestRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortOldestRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortOldestRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortOldestRadio.Location = new System.Drawing.Point(57, 0);
            this.SortOldestRadio.Margin = new System.Windows.Forms.Padding(0);
            this.SortOldestRadio.Name = "SortOldestRadio";
            this.SortOldestRadio.Size = new System.Drawing.Size(53, 25);
            this.SortOldestRadio.TabIndex = 5;
            this.SortOldestRadio.Text = "Oldest";
            this.SortOldestRadio.UseVisualStyleBackColor = false;
            this.SortOldestRadio.CheckedChanged += new System.EventHandler(this.Sort_Changed);
            // 
            // SortMostNotesRadio
            // 
            this.SortMostNotesRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortMostNotesRadio.AutoSize = true;
            this.SortMostNotesRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SortMostNotesRadio.Enabled = false;
            this.SortMostNotesRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortMostNotesRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortMostNotesRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortMostNotesRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortMostNotesRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortMostNotesRadio.Location = new System.Drawing.Point(110, 0);
            this.SortMostNotesRadio.Margin = new System.Windows.Forms.Padding(0);
            this.SortMostNotesRadio.Name = "SortMostNotesRadio";
            this.SortMostNotesRadio.Size = new System.Drawing.Size(78, 25);
            this.SortMostNotesRadio.TabIndex = 6;
            this.SortMostNotesRadio.Text = "Most Notes";
            this.SortMostNotesRadio.UseVisualStyleBackColor = false;
            this.SortMostNotesRadio.CheckedChanged += new System.EventHandler(this.Sort_Changed);
            // 
            // SortFewestNotesRadio
            // 
            this.SortFewestNotesRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortFewestNotesRadio.AutoSize = true;
            this.SortFewestNotesRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SortFewestNotesRadio.Enabled = false;
            this.SortFewestNotesRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortFewestNotesRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortFewestNotesRadio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortFewestNotesRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SortFewestNotesRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortFewestNotesRadio.Location = new System.Drawing.Point(188, 0);
            this.SortFewestNotesRadio.Margin = new System.Windows.Forms.Padding(0);
            this.SortFewestNotesRadio.Name = "SortFewestNotesRadio";
            this.SortFewestNotesRadio.Size = new System.Drawing.Size(88, 25);
            this.SortFewestNotesRadio.TabIndex = 7;
            this.SortFewestNotesRadio.Text = "Fewest Notes";
            this.SortFewestNotesRadio.UseVisualStyleBackColor = false;
            this.SortFewestNotesRadio.CheckedChanged += new System.EventHandler(this.Sort_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sort:";
            // 
            // FiltersButton
            // 
            this.FiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersButton.AutoSize = true;
            this.FiltersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiltersButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersButton.Location = new System.Drawing.Point(690, 3);
            this.FiltersButton.Name = "FiltersButton";
            this.FiltersButton.Size = new System.Drawing.Size(63, 30);
            this.FiltersButton.TabIndex = 2;
            this.FiltersButton.Text = "Filters";
            this.FiltersButton.Click += new System.EventHandler(this.FiltersButton_Click);
            // 
            // ExportGridControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.FilterPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ExportGridControl";
            this.Size = new System.Drawing.Size(991, 552);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TilesPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.CheckedListBox TagsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CollapseFiltersButton;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton SortNewestRadio;
        private System.Windows.Forms.RadioButton SortOldestRadio;
        private System.Windows.Forms.RadioButton SortMostNotesRadio;
        private System.Windows.Forms.RadioButton SortFewestNotesRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FiltersButton;
        private System.Windows.Forms.FlowLayoutPanel TilesPanel;
        private PostPreviewTileControl postPreviewTileControl1;
        private PostPreviewTileControl postPreviewTileControl2;
        private PostPreviewTileControl postPreviewTileControl3;
        private PostPreviewTileControl postPreviewTileControl4;
        private PostPreviewTileControl postPreviewTileControl5;
        private PostPreviewTileControl postPreviewTileControl6;
        private PostPreviewTileControl postPreviewTileControl7;
        private PostPreviewTileControl postPreviewTileControl8;
        private PostPreviewTileControl postPreviewTileControl9;
        private PostPreviewTileControl postPreviewTileControl10;
        private PostPreviewTileControl postPreviewTileControl11;
        private PostPreviewTileControl postPreviewTileControl12;
        private PostPreviewControl PreviewControl;
    }
}
