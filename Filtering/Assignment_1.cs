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
        public static Color[,] RGBtoGrayScale(string path)
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

        public static Color[,] ImagetoRGB(string path) // TODO: Think about whether this implementation of RGB encoding is correct
            
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

                    Color rgb = Color.FromArgb(r, g, b);
                    inputBitmap.SetPixel(i, j, rgb); 

                    inputImage[i, j] = inputBitmap.GetPixel(i, j);
                }
            }
            return inputImage;

        }
    }
}

