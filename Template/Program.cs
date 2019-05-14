using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageUtilities;
using Filtering;

namespace Template
{
    class Program
    {
        public static void RGBImageToGray()
        {
            //string path = args[0]; // right click template -> properties -> Debug -> command line arguments -> "../../../images/tulips.png"
            string path = @"../../../images/forest.jpg";
            string pathout = path.Substring(0, path.LastIndexOf(".")) + "-out" + path.Substring(path.LastIndexOf("."), path.Length - path.LastIndexOf("."));
            Color[,] im = ImageViewer.LoadImage(path);
            Color[,] GrayRGB = Assignment_1.RGBImagetoGrayScale(path); // RGBtoGrayScale
            ImageViewer.DrawImage(GrayRGB);
            ImageViewer.DrawImagePair(GrayRGB, im);
            ImageViewer.SaveImage(im, pathout);
            
        }

      
        public static void Main(string[] args)
        {
            RGBImageToGray(); //Convert RGB image to grayscale
        }
    }
}
