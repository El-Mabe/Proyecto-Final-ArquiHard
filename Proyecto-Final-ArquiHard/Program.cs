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


        public static Object[] version1(Bitmap imagenEnBitmap, String numeroDeBits)
        {
            Object[] imagenYTiempo = new Object[2];
            int numero = 0;

            if (numeroDeBits.Equals("24"))
            {
                //Para profunidad de 24 bits, el maximo valor por canal (R, G o B de 8 bits) es 255
                numero = 255;
            }
            else if (numeroDeBits.Equals("48"))
            {
                //Para profunidad de 24 bits, el maximo valor por canal (R, G o B de 8 bits) es 65535
                numero = 65535;
            }
            else if (numeroDeBits.Equals("96"))
            {
                //Para profunidad de 24 bits, el maximo valor por canal (R, G o B de 8 bits) es 4294967295
                //  numero = 4294967295; ARREGLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAR
            }

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
                    Color newColor = Color.FromArgb(numero - pixelColor.R, pixelColor.G, pixelColor.B);
                    newColor = Color.FromArgb(newColor.R, numero - newColor.G, newColor.B);
                    newColor = Color.FromArgb(newColor.R, newColor.G, numero - newColor.B);
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

        


    }
}
