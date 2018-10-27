namespace WindowsFormsApp1
{
    partial class ViewExportForm
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
            this.GridControl = new WindowsFormsApp1.UserControls.ExportGridControl();
            this.SuspendLayout();
            // 
            // GridControl
            // 
            this.GridControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridControl.ForeColor = System.Drawing.Color.White;
            this.GridControl.Location = new System.Drawing.Point(0, 0);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(970, 621);
            this.GridControl.TabIndex = 2;
            // 
            // ViewExportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(970, 621);
            this.Controls.Add(this.GridControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ViewExportForm";
            this.Text = "ViewExportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ExportGridControl GridControl;
    }
}