namespace MultiDocumentInterface_MDI_
{
    partial class saveOrExit
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
            this.saveInCase = new System.Windows.Forms.Button();
            this.dontSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveInCase
            // 
            this.saveInCase.Location = new System.Drawing.Point(95, 112);
            this.saveInCase.Name = "saveInCase";
            this.saveInCase.Size = new System.Drawing.Size(157, 63);
            this.saveInCase.TabIndex = 0;
            this.saveInCase.Text = "Save File ";
            this.saveInCase.UseVisualStyleBackColor = true;
            this.saveInCase.Click += new System.EventHandler(this.saveInCase_Click);
            // 
            // dontSave
            // 
            this.dontSave.Location = new System.Drawing.Point(394, 112);
            this.dontSave.Name = "dontSave";
            this.dontSave.Size = new System.Drawing.Size(238, 63);
            this.dontSave.TabIndex = 0;
            this.dontSave.Text = "Don\'t Save ";
            this.dontSave.UseVisualStyleBackColor = true;
            this.dontSave.Click += new System.EventHandler(this.dontSave_Click);
            // 
            // saveOrExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 286);
            this.Controls.Add(this.dontSave);
            this.Controls.Add(this.saveInCase);
            this.Name = "saveOrExit";
            this.Text = "Save Changes To Text File";
            this.Load += new System.EventHandler(this.saveOrExit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveInCase;
        private System.Windows.Forms.Button dontSave;
    }
}