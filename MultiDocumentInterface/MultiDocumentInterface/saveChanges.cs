using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace MultiDocumentInterface_MDI_
{
    public partial class saveOrExit : Form
    {
        [System.ComponentModel.Browsable(false)]
        public System.Windows.Forms.Form ActiveMdiChild { get; set;  }

        public saveOrExit()
        {
            InitializeComponent();
        }

        private void saveOrExit_Load(object sender, EventArgs e)
        {

        }

        private void saveInCase_Click(object sender, EventArgs e)
        {

            Form frm = this.ActiveMdiChild;

            TextDocument txt = new TextDocument();
            SaveFileDialog saveTxtFile = new SaveFileDialog();


            saveTxtFile.Filter = "Text File |*.txt";

            if (txt.richTextBox1.Text != null)
            {

                if (saveTxtFile.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(saveTxtFile.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);
                    sw.Write(txt.richTextBox1.Text);

                    this.Close();
                    
                    
                }
             
            }

        }

        private void dontSave_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }
    }
}
