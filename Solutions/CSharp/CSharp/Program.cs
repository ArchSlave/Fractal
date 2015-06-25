using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {

        #region Consts
        // const int imageWidth = 16384;
        // const int imageHeight = 16384;
        const int imageWidth = 800;
        const int imageHeight = 600;
        
        const int MaxColorComponentValue = 255;
        const int IterationMax = 256;
        const int colorSize = 3;
        const double complexXMinimum = -2.5;
        const double complexXMaximum = 2.5;
        const double complexYMinimum = -2.5;
        const double complexYMaximum = 2.5;
        const double EscapeRadius = 2;
        const double ER2 = EscapeRadius * EscapeRadius;
        const double PixelWidth = (complexXMaximum - complexXMinimum) / imageWidth;
        const double PixelHeight = (complexYMaximum - complexYMinimum) / imageHeight;
        #endregion

        static void DrawTheFractalSequentially(NetPbm img)
        {
            for (int yCoordinate = 0; yCoordinate < imageHeight; yCoordinate++)
            {
                double complexY = complexXMinimum + yCoordinate * PixelHeight;
                if (Math.Abs(complexY) < PixelHeight / 2) complexY = 0;

                for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)
                {
                    double complexX = complexXMinimum + xCoordinate * PixelWidth;

                    double Zx = 0.0;
                    double Zy = 0.0;
                    double Zx2 = Zx * Zx;
                    double Zy2 = Zy * Zy;

                    int Iteration;
                    for (Iteration = 0; Iteration < IterationMax && ((Zx2 + Zy2) < ER2); Iteration++)
                    {
                        Zy = 2 * Zx * Zy + complexY;
                        Zx = Zx2 - Zy2 + complexX;
                        Zx2 = Zx * Zx;
                        Zy2 = Zy * Zy;
                    };

                    if (Iteration == IterationMax)
                    {
                        img.SetColor(xCoordinate, yCoordinate, 0, 0, 0);
                    }
                    else
                    {
                        int mod8, mod4, mod2;
                        mod2 = (mod4 = (mod8 = ((IterationMax - Iteration) % 8)) % 4) % 2;

                        img.SetColor(xCoordinate, yCoordinate, (byte)(mod8 * 63), (byte)(mod4 * 127), (byte)(mod2 * 255));
                    };
                }
            }
        }

        static void DrawTheFractalParallel(NetPbm img)
        {

            Parallel.For(0, imageHeight, (yCoordinate) =>
            {

                double complexY = complexXMinimum + yCoordinate * PixelHeight;
                if (Math.Abs(complexY) < (PixelHeight / 2)) complexY = 0;

                for (int xCoordinate = 0; xCoordinate < imageWidth; xCoordinate++)
                {
                    double complexX = complexXMinimum + xCoordinate * PixelWidth;

                    double Zx = 0.0;
                    double Zy = 0.0;
                    double Zx2 = Zx * Zx;
                    double Zy2 = Zy * Zy;

                    int Iteration;
                    for (Iteration = 0; Iteration < IterationMax && ((Zx2 + Zy2) < ER2); Iteration++)
                    {
                        Zy = 2 * Zx * Zy + complexY;
                        Zx = Zx2 - Zy2 + complexX;
                        Zx2 = Zx * Zx;
                        Zy2 = Zy * Zy;
                    };

                    if (Iteration == IterationMax)
                    {
                        img.SetColor(xCoordinate, yCoordinate, 0, 0, 0);
                    }
                    else
                    {
                        int mod8, mod4, mod2;
                        mod2 = (mod4 = (mod8 = ((IterationMax - Iteration) % 8)) % 4) % 2;

                        img.SetColor(xCoordinate, yCoordinate, (byte)(mod8 * 63), (byte)(mod4 * 127), (byte)(mod2 * 255));
                    };
                }
            });

        }

        static void Main(string[] args)
        {
            // System.Diagnostics.Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            var img = new NetPbm(imageWidth, imageHeight);

            
            // DrawTheFractalSequentially(img);
            DrawTheFractalParallel(img);

            img.SaveToFile("mandelbrot.ppm");
        }
    }
}
