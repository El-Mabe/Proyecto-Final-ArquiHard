using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace intento
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = 1;//1: 64x64, 2: 160x160, 3: 512x512, 4: 1500x1500
            //int algoritmo = 1;
            //int tipo = 3;//1: 8, 2: 16, 3: 32

            Console.WriteLine("Por favor ingrese el número de la imagen a editar");
            String numero = Console.ReadLine();

            Console.WriteLine("Por favor ingrese la versión del algoritmo a usar");
            int algoritmo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el tamaño en bits para la imagen: \n 1. 8bits \n 2. 16bits \n 3. 32bits");
            int tipo = Int32.Parse(Console.ReadLine());

            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PF\img\" + numero+".bmp";
            //String ruta = "C:/Users/Principal/Desktop/ImagenesPractica/" + numero + ".bmp";

           
            Bitmap actu = new Bitmap(Image.FromFile(ruta));

            

            switch (algoritmo)
            {
                case 1:

                    switch (tipo)
                    {
                        case 1:
                            ImagenByte imgaByte = new ImagenByte(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaByte.pixeles[i, j] = new RGBByte(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaByte = version1_Byte(imgaByte);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaByte.pixeles[i, j].R, imgaByte.pixeles[i, j].G, imgaByte.pixeles[i, j].B)); ;
                                }
                            }
                                //actu.Save("C:/Users/Principal/Desktop/imagenes/v1.bmp");
                                //actu.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PF\img\"+numero+"-"+tipo + ".bmp");
                                //actu.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/PF/img/" + numero + "-" + tipo + ".bmp");
                                break;
                        case 2:
                            ImagenShort imgaShort = new ImagenShort(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaShort.pixeles[i, j] = new RGBShort(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaShort = version1_Short(imgaShort);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaShort.pixeles[i, j].R, imgaShort.pixeles[i, j].G, imgaShort.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v1.bmp");
                            break;
                        case 3:
                            ImagenInt imgaInt = new ImagenInt(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaInt.pixeles[i, j] = new RGBInt(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaInt = version1_Int(imgaInt);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaInt.pixeles[i, j].R, imgaInt.pixeles[i, j].G, imgaInt.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v1.bmp");
                            break;
                    }
                    break;

                case 2:

                    switch (tipo)
                    {
                        case 1:
                            ImagenByte imgaByte = new ImagenByte(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaByte.pixeles[i, j] = new RGBByte(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaByte = version2_Byte(imgaByte);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaByte.pixeles[i, j].R, imgaByte.pixeles[i, j].G, imgaByte.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v2.bmp");
                            break;
                        case 2:
                            ImagenShort imgaShort = new ImagenShort(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaShort.pixeles[i, j] = new RGBShort(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaShort = version2_Short(imgaShort);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaShort.pixeles[i, j].R, imgaShort.pixeles[i, j].G, imgaShort.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v2.bmp");
                            break;
                        case 3:
                            ImagenInt imgaInt = new ImagenInt(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaInt.pixeles[i, j] = new RGBInt(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaInt = version2_Int(imgaInt);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaInt.pixeles[i, j].R, imgaInt.pixeles[i, j].G, imgaInt.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v2.bmp");
                            break;
                    }
                    break;

                case 3:

                    switch (tipo)
                    {
                        case 1:
                            ImagenByte imgaByte = new ImagenByte(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaByte.pixeles[i, j] = new RGBByte(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaByte = version3_Byte(imgaByte);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaByte.pixeles[i, j].R, imgaByte.pixeles[i, j].G, imgaByte.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v3.bmp");
                            break;
                        case 2:
                            ImagenShort imgaShort = new ImagenShort(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaShort.pixeles[i, j] = new RGBShort(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaShort = version3_Short(imgaShort);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaShort.pixeles[i, j].R, imgaShort.pixeles[i, j].G, imgaShort.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v3.bmp");
                            break;
                        case 3:
                            ImagenInt imgaInt = new ImagenInt(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaInt.pixeles[i, j] = new RGBInt(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaInt = version3_Int(imgaInt);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaInt.pixeles[i, j].R, imgaInt.pixeles[i, j].G, imgaInt.pixeles[i, j].B)); ;
                                }
                            }
                           //actu.Save("C:/Users/Principal/Desktop/imagenes/v3.bmp");
                            break;
                    }
                    break;

                case 4:

                    switch (tipo)
                    {
                        case 1:
                            ImagenByte imgaByte = new ImagenByte(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaByte.pixeles[i, j] = new RGBByte(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaByte = version4_Byte(imgaByte);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaByte.pixeles[i, j].R, imgaByte.pixeles[i, j].G, imgaByte.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v4.bmp");
                            break;
                        case 2:
                            ImagenShort imgaShort = new ImagenShort(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaShort.pixeles[i, j] = new RGBShort(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaShort = version4_Short(imgaShort);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaShort.pixeles[i, j].R, imgaShort.pixeles[i, j].G, imgaShort.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v4.bmp");
                            break;
                        case 3:
                            ImagenInt imgaInt = new ImagenInt(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaInt.pixeles[i, j] = new RGBInt(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaInt = version4_Int(imgaInt);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaInt.pixeles[i, j].R, imgaInt.pixeles[i, j].G, imgaInt.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v4.bmp");
                            break;
                    }
                    break;

                case 5:

                    switch (tipo)
                    {
                        case 1:
                            ImagenByte imgaByte = new ImagenByte(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaByte.pixeles[i, j] = new RGBByte(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaByte = version5_Byte(imgaByte);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaByte.pixeles[i, j].R, imgaByte.pixeles[i, j].G, imgaByte.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v5.bmp");
                            break;
                        case 2:
                            ImagenShort imgaShort = new ImagenShort(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaShort.pixeles[i, j] = new RGBShort(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaShort = version5_Short(imgaShort);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaShort.pixeles[i, j].R, imgaShort.pixeles[i, j].G, imgaShort.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v5.bmp");
                            break;
                        case 3:
                            ImagenInt imgaInt = new ImagenInt(actu.Height, actu.Width);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    imgaInt.pixeles[i, j] = new RGBInt(actu.GetPixel(i, j).R, actu.GetPixel(i, j).G, actu.GetPixel(i, j).B);
                                }
                            }
                            imgaInt = version5_Int(imgaInt);
                            for (int i = 0; i < actu.Height; i++)
                            {
                                for (int j = 0; j < actu.Width; j++)
                                {
                                    actu.SetPixel(i, j, Color.FromArgb(imgaInt.pixeles[i, j].R, imgaInt.pixeles[i, j].G, imgaInt.pixeles[i, j].B)); ;
                                }
                            }
                            //actu.Save("C:/Users/Principal/Desktop/imagenes/v5.bmp");
                            break;
                    }
                    break;
            }
           
            Console.WriteLine("DONE!");
        }

        private static ImagenByte version1_Byte(ImagenByte temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = (byte)(255 - temp.pixeles[i, j].R);
                    temp.pixeles[i, j].G = (byte)(255 - temp.pixeles[i, j].G);
                    temp.pixeles[i, j].B = (byte)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenShort version1_Short(ImagenShort temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = (short)(255 - temp.pixeles[i, j].R);
                    temp.pixeles[i, j].G = (short)(255 - temp.pixeles[i, j].G);
                    temp.pixeles[i, j].B = (short)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenInt version1_Int(ImagenInt temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = 255 - temp.pixeles[i, j].R;
                    temp.pixeles[i, j].G = 255 - temp.pixeles[i, j].G;
                    temp.pixeles[i, j].B = 255 - temp.pixeles[i, j].B;
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }


        private static ImagenByte version2_Byte(ImagenByte temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = (byte)(255 - temp.pixeles[i, j].R);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].G = (byte)(255 - temp.pixeles[i, j].G);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].B = (byte)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenShort version2_Short(ImagenShort temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = (short)(255 - temp.pixeles[i, j].R);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].G = (short)(255 - temp.pixeles[i, j].G);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].B = (short)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;

        }

        private static ImagenInt version2_Int(ImagenInt temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].R = (255 - temp.pixeles[i, j].R);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].G = (255 - temp.pixeles[i, j].G);
                }
            }

            for (int i = 0; i < temp.fil; i++)
            {
                for (int j = 0; j < temp.col; j++)
                {
                    temp.pixeles[i, j].B = (255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }


        private static ImagenByte version3_Byte(ImagenByte temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[j, i].R = (byte)(255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (byte)(255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (byte)(255 - temp.pixeles[j, i].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;

        }

        private static ImagenShort version3_Short(ImagenShort temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[j, i].R = (short)(255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (short)(255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (short)(255 - temp.pixeles[j, i].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenInt version3_Int(ImagenInt temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[j, i].R = (255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (255 - temp.pixeles[j, i].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }


        private static ImagenByte version4_Byte(ImagenByte temp)
        {
            Stopwatch sw = new Stopwatch();



            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[i, j].R = (byte)(255 - temp.pixeles[i, j].R);
                }
            }
            for (int i = temp.col - 1; i >= 0; i--)
            {
                for (int j = temp.fil - 1; j >= 0; j--)
                {
                    temp.pixeles[i, j].G = (byte)(255 - temp.pixeles[i, j].G);
                    temp.pixeles[i, j].B = (byte)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;


        }

        private static ImagenShort version4_Short(ImagenShort temp)
        {
            Stopwatch sw = new Stopwatch();


            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[i, j].R = (short)(255 - temp.pixeles[i, j].R);
                }
            }
            for (int i = temp.col - 1; i >= 0; i--)
            {
                for (int j = temp.fil - 1; j >= 0; j--)
                {
                    temp.pixeles[i, j].G = (short)(255 - temp.pixeles[i, j].G);
                    temp.pixeles[i, j].B = (short)(255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;

        }

        private static ImagenInt version4_Int(ImagenInt temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i++)
            {
                for (int j = 0; j < temp.fil; j++)
                {
                    temp.pixeles[i, j].R = (255 - temp.pixeles[i, j].R);
                }
            }
            for (int i = temp.col - 1; i >= 0; i--)
            {
                for (int j = temp.fil - 1; j >= 0; j--)
                {
                    temp.pixeles[i, j].G = (255 - temp.pixeles[i, j].G);
                    temp.pixeles[i, j].B = (255 - temp.pixeles[i, j].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }


        private static ImagenByte version5_Byte(ImagenByte temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i += 2)
            {
                for (int j = 0; j < temp.fil; j += 2)
                {
                    temp.pixeles[j, i].R = (byte)(255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (byte)(255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (byte)(255 - temp.pixeles[j, i].B);

                    temp.pixeles[j, i + 1].R = (byte)(255 - temp.pixeles[j, i + 1].R);
                    temp.pixeles[j, i + 1].G = (byte)(255 - temp.pixeles[j, i + 1].G);
                    temp.pixeles[j, i + 1].B = (byte)(255 - temp.pixeles[j, i + 1].B);

                    temp.pixeles[j + 1, i].R = (byte)(255 - temp.pixeles[j + 1, i].R);
                    temp.pixeles[j + 1, i].G = (byte)(255 - temp.pixeles[j + 1, i].G);
                    temp.pixeles[j + 1, i].B = (byte)(255 - temp.pixeles[j + 1, i].B);

                    temp.pixeles[j + 1, i + 1].R = (byte)(255 - temp.pixeles[j + 1, i + 1].R);
                    temp.pixeles[j + 1, i + 1].G = (byte)(255 - temp.pixeles[j + 1, i + 1].G);
                    temp.pixeles[j + 1, i + 1].B = (byte)(255 - temp.pixeles[j + 1, i + 1].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenShort version5_Short(ImagenShort temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i += 2)
            {
                for (int j = 0; j < temp.fil; j += 2)
                {
                    temp.pixeles[j, i].R = (short)(255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (short)(255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (short)(255 - temp.pixeles[j, i].B);

                    temp.pixeles[j, i + 1].R = (short)(255 - temp.pixeles[j, i + 1].R);
                    temp.pixeles[j, i + 1].G = (short)(255 - temp.pixeles[j, i + 1].G);
                    temp.pixeles[j, i + 1].B = (short)(255 - temp.pixeles[j, i + 1].B);

                    temp.pixeles[j + 1, i].R = (short)(255 - temp.pixeles[j + 1, i].R);
                    temp.pixeles[j + 1, i].G = (short)(255 - temp.pixeles[j + 1, i].G);
                    temp.pixeles[j + 1, i].B = (short)(255 - temp.pixeles[j + 1, i].B);

                    temp.pixeles[j + 1, i + 1].R = (short)(255 - temp.pixeles[j + 1, i + 1].R);
                    temp.pixeles[j + 1, i + 1].G = (short)(255 - temp.pixeles[j + 1, i + 1].G);
                    temp.pixeles[j + 1, i + 1].B = (short)(255 - temp.pixeles[j + 1, i + 1].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        private static ImagenInt version5_Int(ImagenInt temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < temp.col; i += 2)
            {
                for (int j = 0; j < temp.fil; j += 2)
                {
                    temp.pixeles[j, i].R = (255 - temp.pixeles[j, i].R);
                    temp.pixeles[j, i].G = (255 - temp.pixeles[j, i].G);
                    temp.pixeles[j, i].B = (255 - temp.pixeles[j, i].B);

                    temp.pixeles[j, i + 1].R = (255 - temp.pixeles[j, i + 1].R);
                    temp.pixeles[j, i + 1].G = (255 - temp.pixeles[j, i + 1].G);
                    temp.pixeles[j, i + 1].B = (255 - temp.pixeles[j, i + 1].B);

                    temp.pixeles[j + 1, i].R = (255 - temp.pixeles[j + 1, i].R);
                    temp.pixeles[j + 1, i].G = (255 - temp.pixeles[j + 1, i].G);
                    temp.pixeles[j + 1, i].B = (255 - temp.pixeles[j + 1, i].B);

                    temp.pixeles[j + 1, i + 1].R = (255 - temp.pixeles[j + 1, i + 1].R);
                    temp.pixeles[j + 1, i + 1].G = (255 - temp.pixeles[j + 1, i + 1].G);
                    temp.pixeles[j + 1, i + 1].B = (255 - temp.pixeles[j + 1, i + 1].B);
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine(tiempo);
            return temp;
        }

        class ImagenInt
        {

            public RGBInt[,] pixeles;
            public int fil;
            public int col;

            public ImagenInt(int filas, int columnas)
            {
                pixeles = new RGBInt[filas, columnas];
                fil = filas;
                col = columnas;
            }

        }

        class ImagenShort
        {

            public RGBShort[,] pixeles;
            public int fil;
            public int col;

            public ImagenShort(int filas, int columnas)
            {
                pixeles = new RGBShort[filas, columnas];
                fil = filas;
                col = columnas;
            }

        }

        class ImagenByte
        {

            public RGBByte[,] pixeles;
            public int fil;
            public int col;

            public ImagenByte(int filas, int columnas)
            {
                pixeles = new RGBByte[filas, columnas];
                fil = filas;
                col = columnas;
            }

        }
        class RGBInt
        {
            public int R;
            public int G;
            public int B;

            public RGBInt(int R, int G, int B)
            {
                this.R = R;
                this.G = G;
                this.B = B;
            }
        }

        class RGBShort
        {
            public short R;
            public short G;
            public short B;

            public RGBShort(short R, short G, short B)
            {
                this.R = R;
                this.G = G;
                this.B = B;
            }
        }

        class RGBByte
        {
            public byte R;
            public byte G;
            public byte B;

            public RGBByte(byte R, byte G, byte B)
            {
                this.R = R;
                this.G = G;
                this.B = B;
            }
        }
    }
}
