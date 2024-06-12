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

namespace Notepad_Agile_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Clear(); this will claer the text that is inside the Text Box 
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();//this will open up another Text Box for the User to wrie inside 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//this will open the File Explorer on the users Laptop
            ofd.ShowDialog();//this will allow the User to see the File Explorer 
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();//this will save the information entered in
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();//this will save the information entered 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();//this will Send the User to the Print Function
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//this will close the Form
        }





       
    }




}
