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

                originalImage.SizeMode = PictureBoxSizeMode.StretchImage;
                originalImage.ImageLocation = path; // display in to the original picture box
            }
            
        }

        private void grayBtn_Click(object sender, EventArgs e)
        {
            pc.grayScale();
            convertedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            convertedImage.ImageLocation = "2.jpg";
        }

        private void thresholdBtn_Click(object sender, EventArgs e)
        {
            pc.threshold();
            convertedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            convertedImage.ImageLocation = "3.jpg";
        }

        private void negetiveBtn_Click(object sender, EventArgs e)
        {
            pc.Neg();
            convertedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            convertedImage.ImageLocation = "4.jpg";
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            pc.extract();
        }

        private void transformBtn_Click(object sender, EventArgs e)
        {
            pc.transform();
            convertedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            convertedImage.ImageLocation = "5.jpg";
        }
    }
}
