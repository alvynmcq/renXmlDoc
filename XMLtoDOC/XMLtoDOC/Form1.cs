using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            try
            {
                string dir_path = @dirPathBox.Text;
                string filename;
                string[] filePaths = Directory.GetFiles(dir_path, "*.xml", SearchOption.AllDirectories);

                foreach (string myFile in filePaths)
                {
                    filename = Path.ChangeExtension(myFile, ".doc");
                    System.IO.File.Move(myFile, filename);
                }
                MessageBox.Show("Conversion complete.");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Folder does not exist");
            }
        }
    }
}
