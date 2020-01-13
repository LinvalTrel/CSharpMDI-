namespace MultiDocumentInterface_MDI_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTxtDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDocOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.imageDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitChild = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascaseWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNewDocument = new System.Windows.Forms.ToolStripButton();
            this.toolOpenDocument = new System.Windows.Forms.ToolStripButton();
            this.toolSaveDocument = new System.Windows.Forms.ToolStripButton();
            this.toolHelp = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitChild});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTxtDoc});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newTxtDoc
            // 
            this.newTxtDoc.Name = "newTxtDoc";
            this.newTxtDoc.Size = new System.Drawing.Size(180, 22);
            this.newTxtDoc.Text = "Text Document";
            this.newTxtDoc.Click += new System.EventHandler(this.newTxtDoc_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDocOpen,
            this.imageDocumentToolStripMenuItem});
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // txtDocOpen
            // 
            this.txtDocOpen.Image = ((System.Drawing.Image)(resources.GetObject("txtDocOpen.Image")));
            this.txtDocOpen.Name = "txtDocOpen";
            this.txtDocOpen.Size = new System.Drawing.Size(204, 46);
            this.txtDocOpen.Text = "Text Document";
            this.txtDocOpen.Click += new System.EventHandler(this.textDocumentToolStripMenuItem1_Click);
            // 
            // imageDocumentToolStripMenuItem
            // 
            this.imageDocumentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageDocumentToolStripMenuItem.Image")));
            this.imageDocumentToolStripMenuItem.Name = "imageDocumentToolStripMenuItem";
            this.imageDocumentToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.imageDocumentToolStripMenuItem.Text = "Image Document";
            this.imageDocumentToolStripMenuItem.Click += new System.EventHandler(this.imageDocumentToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitChild
            // 
            this.exitChild.Image = ((System.Drawing.Image)(resources.GetObject("exitChild.Image")));
            this.exitChild.Name = "exitChild";
            this.exitChild.Size = new System.Drawing.Size(204, 46);
            this.exitChild.Text = "Exit";
            this.exitChild.Click += new System.EventHandler(this.exitChild_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascaseWindowsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascaseWindowsToolStripMenuItem
            // 
            this.cascaseWindowsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cascaseWindowsToolStripMenuItem.Image")));
            this.cascaseWindowsToolStripMenuItem.Name = "cascaseWindowsToolStripMenuItem";
            this.cascaseWindowsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cascaseWindowsToolStripMenuItem.Text = "Cascase Windows";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutMeToolStripMenuItem.Image")));
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me ";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewDocument,
            this.toolOpenDocument,
            this.toolSaveDocument,
            this.toolHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNewDocument
            // 
            this.toolNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNewDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolNewDocument.Image")));
            this.toolNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewDocument.Name = "toolNewDocument";
            this.toolNewDocument.Size = new System.Drawing.Size(23, 22);
            this.toolNewDocument.Text = "toolStripButton1";
            this.toolNewDocument.Click += new System.EventHandler(this.toolNewDocument_Click);
            // 
            // toolOpenDocument
            // 
            this.toolOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpenDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolOpenDocument.Image")));
            this.toolOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpenDocument.Name = "toolOpenDocument";
            this.toolOpenDocument.Size = new System.Drawing.Size(23, 22);
            this.toolOpenDocument.Text = "toolStripButton1";
            this.toolOpenDocument.Click += new System.EventHandler(this.toolOpenDocument_Click);
            // 
            // toolSaveDocument
            // 
            this.toolSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolSaveDocument.Image")));
            this.toolSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveDocument.Name = "toolSaveDocument";
            this.toolSaveDocument.Size = new System.Drawing.Size(23, 22);
            this.toolSaveDocument.Text = "toolStripButton1";
            this.toolSaveDocument.Click += new System.EventHandler(this.toolSaveDocument_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolHelp.Image")));
            this.toolHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(23, 22);
            this.toolHelp.Text = "toolStripButton1";
            this.toolHelp.Click += new System.EventHandler(this.toolHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "MDI Project - Jordan Trelford -  Concepts 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitChild;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascaseWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtDocOpen;
        private System.Windows.Forms.ToolStripMenuItem imageDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTxtDoc;
        public System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNewDocument;
        private System.Windows.Forms.ToolStripButton toolOpenDocument;
        private System.Windows.Forms.ToolStripButton toolSaveDocument;
        private System.Windows.Forms.ToolStripButton toolHelp;
    }
}

