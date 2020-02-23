using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp; // import the openCV sharp library

namespace IPU_first_Lab
{
    class Preprocessor
    {
        IplImage SourceImage; // declear a varibale for store original image
        IplImage grayImage;
        IplImage binaryImage;
        IplImage negetiveImage;
        IplImage cvtNegativeImage;

        public void loadOriginalImage(String filename)
        {
            SourceImage = Cv.LoadImage(filename, LoadMode.Color); // Original Image Load to the Picture Box
            Cv.SaveImage("1.jpg", SourceImage); // get a copy of original image
        }

        //convert image to gray
        public void grayScale()
        {
            grayImage = Cv.CreateImage(SourceImage.Size, BitDepth.U8, 1); // create a new image same as the original image
            Cv.CvtColor(SourceImage, grayImage, ColorConversion.RgbToGray); // RGB to Gray Conversion
            Cv.SaveImage("2.jpg", grayImage); // get a copy of gray image
        }

        public void threshold()
        {
            // convert to color image to gray
            grayScale();
            binaryImage = Cv.CreateImage(SourceImage.Size, BitDepth.U8, 1);
            Cv.Threshold(grayImage, binaryImage, 180, 255, ThresholdType.Binary);
            Cv.SaveImage("3.jpg", binaryImage);
        }

        public void negetive()
        {
            grayScale();
            negetiveImage = Cv.CreateImage(SourceImage.Size, BitDepth.U8, 1);
            
        }

        public void extract()
        {
            System.Windows.Forms.MessageBox.Show("Height: " + SourceImage.Height + " Width: " + SourceImage.Width + " No of Channel: " + SourceImage.NChannels);
        }


        public void Neg()
        {
            grayScale();
            IplImage negImage = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            Cv.Not(grayImage, negImage);
            Cv.SaveImage("4.jpg", negImage);
        }

        public void CvtNegative()
        {
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    double getPixValue = 0;
                    getPixValue = Cv.GetReal2D(grayImage, y, x);
                    double nexPixValue = 255 - getPixValue;
                    Cv.SetReal2D(cvtNegativeImage, y, x, nexPixValue);
                }
            }
        }

        public void transform()
        {
            grayScale();
            cvtNegativeImage = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            CvtNegative();
            Cv.SaveImage("5.jpg", cvtNegativeImage);
        }

    }
}
