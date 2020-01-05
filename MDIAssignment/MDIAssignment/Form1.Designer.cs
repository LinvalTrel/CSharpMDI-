namespace MDIAssignment
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.openTab = new System.Windows.Forms.ToolStripMenuItem();
            this.openTxtDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1781, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileTab
            // 
            this.FileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTab,
            this.openTab});
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(87, 45);
            this.FileTab.Text = "File";
            // 
            // NewTab
            // 
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(448, 54);
            this.NewTab.Text = "New";
            // 
            // openTab
            // 
            this.openTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTxtDoc});
            this.openTab.Name = "openTab";
            this.openTab.Size = new System.Drawing.Size(448, 54);
            this.openTab.Text = "Open";
            // 
            // openTxtDoc
            // 
            this.openTxtDoc.Name = "openTxtDoc";
            this.openTxtDoc.Size = new System.Drawing.Size(384, 54);
            this.openTxtDoc.Text = "Text Document";
            this.openTxtDoc.Click += new System.EventHandler(this.openTxtDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1254);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileTab;
        private System.Windows.Forms.ToolStripMenuItem NewTab;
        private System.Windows.Forms.ToolStripMenuItem openTab;
        private System.Windows.Forms.ToolStripMenuItem openTxtDoc;
    }
}

