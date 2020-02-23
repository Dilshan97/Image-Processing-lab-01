using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPU_first_Lab
{
    public partial class Form1 : Form
    {
        Preprocessor pc = new Preprocessor(); // create a object from preprocessor class
        OpenFileDialog of = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            of.Title = "Select the image";
            of.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "ALLFiles(*.*)|*.*";

            if (of.ShowDialog() == DialogResult.OK)
            {
                pc.loadOriginalImage(of.FileName); // call  the load image method
                String path = of.FileName.ToString();
                originalImage.ImageLocation = path; // display in to the original picture box

            }
            
        }

        private void grayBtn_Click(object sender, EventArgs e)
        {
            pc.grayScale();
            convertedImage.ImageLocation = "2.jpg";
        }

        private void thresholdBtn_Click(object sender, EventArgs e)
        {
            pc.threshold();
            convertedImage.ImageLocation = "3.jpg";
        }

        private void negetiveBtn_Click(object sender, EventArgs e)
        {
            pc.negetive();
        }
    }
}
