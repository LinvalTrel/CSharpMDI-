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
    public partial class Form1 : Form
    {
        [System.ComponentModel.Browsable(false)]
        public System.Windows.Forms.Form ActiveMdiChild { get; }

      

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
 
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

                }
            }
          
        }
       
        private void textDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextDocument txtDoc = new TextDocument(); 
            
            // Write code of text to
            Stream myStream;

            // create new openfiledialog variable 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // create inital directory of where the text file resides 
            openFileDialog1.InitialDirectory = "C:\\Users\\User\\Documents\\Portfolio\\C#\\MultiDocumentInterface(MDI)\\txt docs";
            // allowing the openfiledialog box only to open txt files 
            openFileDialog1.Filter = "txt files (*.txt)|*txt";


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                   
                    //set the parent form to te Child window 
                    txtDoc.MdiParent = this;
                    txtDoc.Show(); 
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    txtDoc.richTextBox1.Text = filetext; 

                    

                }
            }

            if (txtDoc.richTextBox1.Text != null)
            {
                saveAsToolStripMenuItem.Enabled = true; 
            }

        }

        private void newTxtDoc_Click(object sender, EventArgs e)
        {
            TextDocument newText = new TextDocument();

            newText.MdiParent = this;
            newText.Show(); 

            if (newText.richTextBox1.Text != null)
            {
                saveAsToolStripMenuItem.Enabled = true; 
            }

        }

        private void imageDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageDocument imgDoc = new ImageDocument();

            Stream myStream;

            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "image file (*.bmp, *.jpeg, *.jpg, *.png)|*.bmp; *.jpeg;  *.jpg;  *.png"; 
            openImage.InitialDirectory = "C:\\Users\\User\\Documents\\Portfolio\\C#\\MultiDocumentInterface(MDI)\\ImageDocs";

            if (openImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openImage.OpenFile()) != null)
                {
                    imgDoc.MdiParent = this;
                    imgDoc.Show();

                    imgDoc.pictureBox1.Image = new Bitmap(openImage.FileName); 
                    
                }
            }
        }

        private void exitChild_Click(object sender, EventArgs e)
        {
            saveOrExit saveChan = new saveOrExit();
            TextDocument text = new TextDocument();
            ImageDocument img = new ImageDocument();
            Form activeChild = this.ActiveMdiChild;
            SaveFileDialog saveTxtFile = new SaveFileDialog();
            saveTxtFile.Filter = "Text File |*.txt";

            foreach (Form c in this.MdiChildren)
            {
                if(c is TextDocument)
                {
                    string message = "would you like to to save this text file?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    string caption = "Save File"; 
                    DialogResult result; 

                    result = MessageBox.Show(message, caption, buttons);
                    
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (saveTxtFile.ShowDialog() == DialogResult.OK)

                        {
                            Stream s = File.Open(saveTxtFile.FileName, FileMode.CreateNew);
                            StreamWriter sw = new StreamWriter(s);
                            sw.Write(text.richTextBox1.Text);

                            c.Close(); 
                        }
                    }

                    else if (result == System.Windows.Forms.DialogResult.No)
                    {
                        c.Close(); 
                    }
                }

                else if(c is ImageDocument)
                {
                    c.Close(); 
                }

                else
                {
                    c.Close(); 
                }

            }

            Application.Exit(); 
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe openAbout = new AboutMe();
            openAbout.Show(); 

        }
    }
}
