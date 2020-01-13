namespace MultiDocumentInterface_MDI_
{
    partial class AboutMe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Application was created by Jordan Trelford ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "for PROG 1815";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // okClose
            // 
            this.okClose.Location = new System.Drawing.Point(360, 290);
            this.okClose.Name = "okClose";
            this.okClose.Size = new System.Drawing.Size(197, 69);
            this.okClose.TabIndex = 1;
            this.okClose.Text = "OK ";
            this.okClose.UseVisualStyleBackColor = true;
            this.okClose.Click += new System.EventHandler(this.okClose_Click);
            // 
            // AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 455);
            this.Controls.Add(this.okClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AboutMe";
            this.Text = "About Me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okClose;
    }
}