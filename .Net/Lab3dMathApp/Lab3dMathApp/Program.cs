using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using static System.Console;

namespace Lab3dMathApp
{
	class Program
    {
		public const string _remoteImageUrl = "https://www.researchgate.net/profile/Jan_Blommaert/publication/265850004/figure/fig2/AS:392183849996307@1470515324911/Bitch-please-meme-Google-Images-downloaded-September-1-2014.png";


		public const int _asciiWidth = 150;

		public static string[] _asciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };

		//from http://stackoverflow.com/questions/12142634/download-image-and-create-bitmap
		private static Bitmap GetBitmapFromUrl(string remoteImageUrl)
		{
			WebRequest request = WebRequest.Create(remoteImageUrl);
			WebResponse response = request.GetResponse();
			Stream responseStream = response.GetResponseStream();
			Bitmap bitmap = new Bitmap(responseStream);
			return bitmap;
		}


		//from http://www.c-sharpcorner.com/uploadfile/dheenu27/imagetoasciiconverter03022007164455pm/imagetoasciiconverter.aspx
		public static string ConvertImageToAsciiArt(Bitmap image)
		{
			image = GetReSizedImage(image, _asciiWidth);

			//Convert the resized image into ASCII
			string ascii = ConvertToAscii(image);
			return ascii;
		}

		public static Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
		{
			int asciiHeight = 0;
			//Calculate the new Height of the image from its width
			asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);

			//Create a new Bitmap and define its resolution
			Bitmap result = new Bitmap(asciiWidth, asciiHeight);
			Graphics g = Graphics.FromImage((Image)result);
			//The interpolation mode produces high quality images 
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
			g.Dispose();
			return result;
		}


		public static string ConvertToAscii(Bitmap image)
		{
			Boolean toggle = false;
			StringBuilder sb = new StringBuilder();

			for (int h = 0; h < image.Height; h++)
			{
				for (int w = 0; w < image.Width; w++)
				{
					Color pixelColor = image.GetPixel(w, h);
					//Average out the RGB components to find the Gray Color
					int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					Color grayColor = Color.FromArgb(red, green, blue);

					//Use the toggle flag to minimize height-wise stretch
					if (!toggle)
					{
						int index = (grayColor.R * 10) / 255;
						sb.Append(_asciiChars[index]);
					}
				}

				if (!toggle)
				{
					sb.Append(Environment.NewLine);
					toggle = true;
				}
				else
				{
					toggle = false;
				}
			}

			return sb.ToString();
		}
		static int Plus()
        {
            int a, b;
            WriteLine("a + b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a + b;
            WriteLine(a + " + " + b + " = " + total);
            return total;
        }
        static int Subtract()
        {
            int a, b;
            WriteLine("a - b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a - b;
            WriteLine(a + " - " + b + " = " + total);
            return total;
        }
        static int Multiply()
        {
            int a, b;
            WriteLine("a x b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a * b;
            WriteLine(a + " x " + b + " = " + total);
            return total;
        }
        static int Divide()
        {
            int a, b;
            WriteLine("a / b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a / b;
            WriteLine(a + " / " + b + " = " + total);
            return total;
        }
        static void Main()
        {
            WriteLine("(1.) Add\n(2.) Subtract\n(3.) Multiply\n(4.) Divide\n(5.) Exit");
            try
            {
                int n = Convert.ToInt32(ReadLine());
                if (n == 1)
                    WriteLine(Plus());
                else if (n == 2)
                    WriteLine(Subtract());
                else if (n == 3)
                    WriteLine(Multiply());
                else if (n == 4)
                    WriteLine(Divide());
                else if (n == 5)
                    System.Environment.Exit(0);
            }
            catch
            {
				Bitmap image = GetBitmapFromUrl(_remoteImageUrl);

				string ascii = ConvertImageToAsciiArt(image);
				Console.Write(ascii);
				Main();
            }
        }
    }
}
