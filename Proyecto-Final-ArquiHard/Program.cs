using System;
using System.Diagnostics;
using System.Drawing;

namespace Proyecto_Final_ArquiHard
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }

        public static Object[] version1(Bitmap imagenEnBitmap)
        {
            Object[] imagenYTiempo = new Object[2];
            
            //Medicion de tiempo
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();

            // Iteracion de los pixeles de la imagen para invertir su color.
            int x, y;
            for (x = 0; x < imagenEnBitmap.Width; x++)
            {
                for (y = 0; y < imagenEnBitmap.Height; y++)
                {
                    Color pixelColor = imagenEnBitmap.GetPixel(x, y);
                    Color newColor = Color.FromArgb(255 - pixelColor.R, pixelColor.G, pixelColor.B);
                    newColor = Color.FromArgb(newColor.R, 255 - newColor.G, newColor.B);
                    newColor = Color.FromArgb(newColor.R, newColor.G, 255 - newColor.B);
                    imagenEnBitmap.SetPixel(x, y, newColor);
                }
            }
            sw.Stop();
            //------------------------------------------------

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Image nueva = (Image)imagenEnBitmap;
            imagenYTiempo[0] = nueva;
            imagenYTiempo[1] = tiempo;

            return imagenYTiempo;
        }

        public static object[] version2(Bitmap imagenEnBitmap)
        {

            object[] imagenYTiempo = new object[2];

            //Medicion de tiempo
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
           
            for (int x = 0; x < imagenEnBitmap.Width; x++)
            {
                for (int y = 0; y < imagenEnBitmap.Height; y++)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(255 - c.R, c.G, c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);
                }
            }

            for (int x = 0; x < imagenEnBitmap.Width; x++)
            {
                for (int y = 0; y < imagenEnBitmap.Height; y++)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(c.R, 255 - c.G, c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);
                }
            }

            for (int x = 0; x < imagenEnBitmap.Width; x++)
            {
                for (int y = 0; y < imagenEnBitmap.Height; y++)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(c.R, c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);
                }
            }
            sw.Stop();


            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Image nueva = (Image)imagenEnBitmap;
            imagenYTiempo[0] = nueva;
            imagenYTiempo[1] = tiempo;

            /*
            imagenEnBitmap.Save("C:/Users/Principal/Desktop/imagenes/v2.jpg");
            Console.WriteLine("fin 2");
            */
            //end
            
            /*
            String ruta = "";
            Bitmap bm3 = new Bitmap(Image.FromFile(ruta));
            */
            return imagenYTiempo;
        }


        public static Object[] version3(Bitmap imagenEnBitmap)
        {
            Object[] imagenYTiempo = new Object[2];


            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            //version 3
            for (int x = 0; x < imagenEnBitmap.Height; x++)
            {
                for (int y = 0; y < imagenEnBitmap.Width; y++)
                {
                    Color c = imagenEnBitmap.GetPixel(y, x);
                    Color nuevo = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(y, x, nuevo);
                }
            }
            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Image nueva = (Image)imagenEnBitmap;
            imagenYTiempo[0] = nueva;
            imagenYTiempo[1] = tiempo;

            /*
            imagenEnBitmap.Save("C:/Users/Principal/Desktop/imagenes/v3.jpg");
            Console.WriteLine("fin 3");
            //end

            Bitmap bm4 = new Bitmap(Image.FromFile(ruta));
            */


            return imagenYTiempo;
        }

        public static Object version4(Bitmap imagenEnBitmap)
        {
            Object[] imagenYTiempo = new Object[2];


            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            //version 4
            for (int x = 0; x < imagenEnBitmap.Width; x++)
            {
                for (int y = 0; y < imagenEnBitmap.Height; y++)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(255 - c.R, c.G, c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);
                }
            }

            for (int x = imagenEnBitmap.Width - 1; x > -1; x--)
            {
                for (int y = imagenEnBitmap.Height - 1; y > -1; y--)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);
                }
            }
            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Image nueva = (Image)imagenEnBitmap;
            imagenYTiempo[0] = nueva;
            imagenYTiempo[1] = tiempo;
            /*
            imagenEnBitmap.Save("C:/Users/Principal/Desktop/imagenes/v4.jpg");
            Console.WriteLine("fin 4");
            //end


            Bitmap bm5 = new Bitmap(Image.FromFile(ruta));
            */
            return imagenYTiempo;
        }

        public static Object version5(Bitmap imagenEnBitmap)
        {
            Object[] imagenYTiempo = new Object[2];


            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();

            //version 5

            for (int x = 0; x < imagenEnBitmap.Width - 1; x += 2)
            {
                for (int y = 0; y < imagenEnBitmap.Height - 1; y += 2)
                {
                    Color c = imagenEnBitmap.GetPixel(x, y);
                    Color nuevo = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x, y, nuevo);

                    c = imagenEnBitmap.GetPixel(x, y + 1);
                    nuevo = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x, y + 1, nuevo);

                    c = imagenEnBitmap.GetPixel(x + 1, y);
                    nuevo = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x + 1, y, nuevo);

                    c = imagenEnBitmap.GetPixel(x + 1, y + 1);
                    nuevo = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    imagenEnBitmap.SetPixel(x + 1, y + 1, nuevo);
                }
            }
            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Image nueva = (Image)imagenEnBitmap;
            imagenYTiempo[0] = nueva;
            imagenYTiempo[1] = tiempo;

            /*
            imagenEnBitmap.Save("C:/Users/Principal/Desktop/imagenes/v5.jpg");
            Console.WriteLine("fin 5");
            //end
            */
            return imagenYTiempo;
        }


    }
}
