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

            Form frm = this.ActiveMdiChild; // 'frm' variable is for every active form on display 

            TextDocument txt = new TextDocument(); 
            SaveFileDialog saveTxtFile = new SaveFileDialog();
            saveTxtFile.Filter = "Text File |*.txt"; // only files that are .txt can be saved
            
            if (txt.richTextBox1.Text != null)
            {               

                if (saveTxtFile.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(saveTxtFile.FileName, FileMode.CreateNew); 
                    StreamWriter sw = new StreamWriter(s);
                    sw.Write(txt.richTextBox1.Text); //content written into the text file is saved as a filename by the choice of the user 

                }
            }
          
        }
       
        private void textDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextDocument txtDoc = new TextDocument(); 
            
            Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.InitialDirectory = "C:\\Users";  // intial directory to open files will be the Users, because local servers differ
            
            openFileDialog1.Filter = "txt files (*.txt)|*txt";


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null) 
                {
               
                    txtDoc.MdiParent = this; //set the parent form to te Child window  
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
            openImage.InitialDirectory = "C:\\Users";

            if (openImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openImage.OpenFile()) != null)
                {
                    imgDoc.MdiParent = this;
                    imgDoc.Show();

                    imgDoc.pictureBox1.Image = new Bitmap(openImage.FileName); // using Bitmap open only images to fill the rich text box 
                    
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

            foreach (Form c in this.MdiChildren) // child text forms are known as c in this loop 
            {
                if(c is TextDocument) // if 'c'(text forms) are open, give user option to save that text file
                {
                    string message = "would you like to to save this text file?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo; // save or close dialog 
                    string caption = "Save File"; 
                    DialogResult result; 

                    result = MessageBox.Show(message, caption, buttons);
                    
                    if (result == System.Windows.Forms.DialogResult.Yes) // if user chooses to save form, open save dialog box 
                    {

                        if (saveTxtFile.ShowDialog() == DialogResult.OK)
                        {
                            Stream s = File.Open(saveTxtFile.FileName, FileMode.CreateNew); // create new file to save the form in 
                            StreamWriter sw = new StreamWriter(s);
                            sw.Write(text.richTextBox1.Text);

                            c.Close();  // close text form 
                        }
                    }

                    else if (result == System.Windows.Forms.DialogResult.No)
                    {
                        c.Close(); // if user chooses not to save the form, close form 
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

/************* 
 
      IMAGE TOLL STRIPS

 ***************/ 

        private void toolNewDocument_Click(object sender, EventArgs e)
        {
            TextDocument newText = new TextDocument();

            newText.MdiParent = this;
            newText.Show();

            if (newText.richTextBox1.Text != null)
            {
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolOpenDocument_Click(object sender, EventArgs e)
        {
            // tool bar option will accept text files and certain image files 

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|Image files (*.jpg, *.jpeg, *bmp) | *.jpg, *.jpeg, *bmp ";
            dialog.InitialDirectory = @"C:\User"; 
            dialog.Title = "Please select an image or a text file"; 

            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void toolSaveDocument_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;

            ImageDocument img = new ImageDocument(); 
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

        private void toolHelp_Click(object sender, EventArgs e)
        {
            AboutMe openAbout = new AboutMe();
            openAbout.Show();

        }
    }
}
