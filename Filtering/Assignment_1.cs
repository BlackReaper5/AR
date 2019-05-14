using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageUtilities;


namespace Filtering
{
    public class Assignment_1
    {
        public static Color[,] RGBImagetoGrayScale(string path)
        {
            Bitmap inputBitmap = new Bitmap(path);

            Color[,] inputImage = ImageViewer.Bitmap2colorm(inputBitmap);
            for (int i = 0; i < inputBitmap.Width; i++)
            {
                for (int j = 0; j < inputBitmap.Height; j++)
                {
                    Color coloredpixels = inputBitmap.GetPixel(i, j); 
                    byte r = coloredpixels.R;
                    byte g = coloredpixels.G;
                    byte b = coloredpixels.B;
                    int avg = (r + g + b) / 3;
                    Color avgColor = Color.FromArgb(avg, avg, avg);
                    inputBitmap.SetPixel(i, j, avgColor); 

                    inputImage[i, j] = inputBitmap.GetPixel(i, j);
                }
            }
            return inputImage;

        }

        public static Color[,] RGBImageToYUV(string path) 
            
        {
            Bitmap inputBitmap = new Bitmap(path);
            
            Color[,] inputImage = ImageViewer.Bitmap2colorm(inputBitmap);
            for (int i = 0; i < inputBitmap.Width; i++)
            {
                for (int j = 0; j < inputBitmap.Height; j++)
                {
                    // Getting the RGB values of the image
                    Color coloredpixels = inputBitmap.GetPixel(i, j); 
                    double r = Convert.ToDouble(coloredpixels.R) / 255;
                    double g = Convert.ToDouble(coloredpixels.G) / 255;
                    double b = Convert.ToDouble(coloredpixels.B) / 255;

                    double WR = 0.299;
                    double WB = 0.114;
                    double WG = 1 - WR - WB;

                    double UMax = 0.436;
                    double VMax = 0.615;

                    // Converting the RGB values to YUV
                    double Y = (WR * r) + (WG * g) + (WB * b);
                    double U = UMax * ((b - Y) / (1 - WR));
                    double V = VMax * ((r - Y) / (1 - WR));

                    // TODO think about how to implement the YUV in image
                    //inputBitmap.SetPixel(i, j, YUV); 

                    inputImage[i, j] = inputBitmap.GetPixel(i, j);
                }
            }
            return inputImage;

        }
    }
}

