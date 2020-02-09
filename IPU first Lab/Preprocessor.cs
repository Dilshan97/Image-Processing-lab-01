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

        public void loadOriginalImage()
        {
            SourceImage = Cv.LoadImage("apples.jpg", LoadMode.Color); // Original Image Load to the Picture Box
            Cv.SaveImage("1.jpg", SourceImage); // get a copy of original image
        }

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
    }
}
