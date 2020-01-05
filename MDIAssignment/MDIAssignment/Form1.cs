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
namespace MDIAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1 form1 = new Form1();

            TextDocument form2 = new TextDocument();
            form2.MdiParent = form1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newTxtDoc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void openTxtDoc_Click(object sender, EventArgs e)
        {
            TextDocument txtdoc = new TextDocument(); 

            //Write code of text to 
            Stream myStream; 

            // create new openfiledialog variable 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // create inital directory of where the text file resides 
            openFileDialog1.InitialDirectory = "C:\\Users\\User\\Documents\\Portfolio\\C#\\MultiDocumentInterface(MDI)\txt docs";
            // 
            openFileDialog1.Filter = "txt files (*.txt)|*txt"; 

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    txtdoc.Text = filetext; 
                }
            }
        }
    }
}
