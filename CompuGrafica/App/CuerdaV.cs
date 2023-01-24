using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CompuGrafica.App
{
    internal class CuerdaV : Vector
    {
        private int l = 4;
        private int c = 1;
        public double t = 0.2;

        public void Fourier(double x, out double fou)
        {
            double ak, bk, sumF;
            sumF = 0;
            int n = 0;
            double pi = 3.14; //Math.PI;
            do
            {
               /* n += 1;
                ak = (3/6) * (0 + 4 * f(1.5) * Math.Sin(n * pi * (1.5 /3)) + f(3) * Math.Sin(n * pi));
                ak = ak * (2/3);
                bk = (3/6) * (0 + 4 * g(1) * Math.Sin(n * pi * 1.5/3) + (g(1) * Math.Sin(n * pi)));
                
                bk = bk * (2 / (n * pi * c));
                sumF = sumF + (ak * Math.Cos(((n * pi * c * t) / l)) + bk * Math.Sin(((n * 3.14 * c * t) / l))) * Math.Sin(n * pi * x / l);*/
                
                // De 0 a 4
                n += 1;
                /* ak = (2/3) * (0 + 4 * f(2) * Math.Sin(n * pi * 0.5) + f(4) * Math.Sin(n * pi));
                 ak *= 0.5;
                 bk = (2/3) * (0 + 4 * g(2) * Math.Sin(n * pi /2) + g(4) * Math.Sin(n * pi));
                 bk *= 2 / (n * pi * c); //Factor (2/n pi c)

                 sumF += (ak * Math.Cos((n * pi * c * t) / l) + bk * Math.Sin((n * pi * c * t) / 3)) * Math.Sin((n * pi * x )/ l);*/
                double di = (2.0 / 3.0);
                ak = di * (0 + l * f(2) * Math.Sin(n * pi * 0.5) + f(l) * Math.Sin(n * pi));
                ak *= 0.5;
                bk = di * (0 + l * g(2) * Math.Sin(n * pi / 2) + g(l) * Math.Sin(n * pi));
                bk *= 2 / (n * pi * c); //Factor (2/n pi c)
                Console.WriteLine("LLEGO:" + ak + "-" + bk + "- " + di + "-" + f(2));
                sumF += (ak * Math.Cos((n * pi * c * t) / l) + bk * Math.Sin((n * pi * c * t) / 3)) * Math.Sin((n * pi * x) / l);

            } while (n <= 20);

            fou = sumF;
        }

        public double f(double x) {
            return (-x * (x-4)) / 2; //  5.33
        }
        public double g(double x)
        {
            return x; //  5.33
        }
        public void GrafFourier(Bitmap canva)
        {
            double h = 0, dh = 0.005;
            Vector vec = new Vector();
            vec.color0 = Color.Red;
            do
            {
                vec.x0 = h;
                Fourier(h, out double fou);
                vec.y0 = fou;
                vec.Encender(canva);
                h += dh;
            } while (h <= 4);
        }
    }
}
