using CompuGrafica.App3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App
{
    internal class Onda
    {
        public double t;
        Color[] paleta1 = new Color[16];
        public void GrafO(Bitmap bmp)
        {
            for (int ii = 0; ii < paleta1.Length; ii++)
            {
                int green_interpolado = (int) lagrange(ii, 0, 15, 100, 230);
                int blue_interpolado = (int)lagrange(ii, 0, 15, 105, 220);
                paleta1[ii] = Color.FromArgb(green_interpolado, green_interpolado, blue_interpolado);
            }
            /*paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;*/

            int i, j, color;
            double x, y;
            double z;
            Color c;


            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    init(i, j, out x, out y);
                    z = 1.5 * (Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)))) - 9.3 * t;
                    z = Math.Sin(z) + 1;
                    color = (int)(z * 7.5);
                    c = paleta1[color];

                    bmp.SetPixel(i, j, c);

                }
            }
        }

        public void GrafoInterferencia(Bitmap bmp)
        {
            /*for (int ii = 0; ii < paleta1.Length; ii++)
            {
                int green_interpolado = (int)lagrange(ii, 0, 15, 100, 230);
                int blue_interpolado = (int)lagrange(ii, 0, 15, 105, 220);
                paleta1[ii] = Color.FromArgb(green_interpolado, green_interpolado, blue_interpolado);
            }*/
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int i, j, color;
            double x, y;
            double z, z1, z2;
            double w = 1.5;
            double v = 9.5;
            Color c;


            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    init(i, j, out x, out y);
                    z1 = w * (Math.Sqrt((x-0)*(x-0)+(y-3)*(y-3))) - v * t;
                    z2 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y  + 3))) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z = z1 + z2;

                    color = (int)(z * 3.75);
                    c = paleta1[color];

                    bmp.SetPixel(i, j, c);

                }
            }
        }


        public void GrafoInterferencia3(Bitmap bmp)
        {
            /*for (int ii = 0; ii < paleta1.Length; ii++)
            {
                int green_interpolado = (int)lagrange(ii, 0, 15, 100, 230);
                int blue_interpolado = (int)lagrange(ii, 0, 15, 105, 220);
                paleta1[ii] = Color.FromArgb(green_interpolado, green_interpolado, blue_interpolado);
            }*/
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int i, j, color;
            double x, y;
            double z, z1, z2, z3;
            double w = 1.5;
            double v = 9.5;
            Color c;


            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    init(i, j, out x, out y);
                    z1 = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3))) - v * t;
                    z2 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3))) - v * t;
                    //z3 = w * (Math.Sqrt((x -5) * (x -5) + (y - 4) * (y - 4))) - v * t;
                    z3 = w * (Math.Sqrt((x + 1.5) * (x + 1.5) + (y + 4) * (y + 4))) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;

                    z = z1 + z2 + z3;

                    color = (int)(z * 2.5);
                    c = paleta1[color];

                    bmp.SetPixel(i, j, c);

                }
            }
        }

        public void GrafoInterferencia11(Bitmap bmp)
        {
            /*for (int ii = 0; ii < paleta1.Length; ii++)
            {
                int green_interpolado = (int)lagrange(ii, 0, 15, 100, 230);
                int blue_interpolado = (int)lagrange(ii, 0, 15, 105, 220);
                paleta1[ii] = Color.FromArgb(green_interpolado, green_interpolado, blue_interpolado);
            }*/

            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int i, j, color;
            double x, y;
            double z;
            double w = 1.5;
            double v = 9.5;
            Color c;

            // Puntos elegidos
            // recta x/2 de -5 a 5 completando 11 putos

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    init(i, j, out x, out y);
                    double res = 0;
                    for (int pos =-5; pos<=5; pos++) {
                       
                        z = w * (Math.Sqrt((x - pos) * (x - pos) + (y - (pos/2.0)) * (y - (pos/2.0))) - (v * t));
                        res += Math.Sin(z) + 1;

                    }
                    
                    color = (int)(res <15?res: 15);
                    c = paleta1[color];

                    bmp.SetPixel(i, j, c);

                }
            }
        }

        public void Onda3D(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Black;
            double x, y, z, d, m, w, v;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color0 = Color.Red;
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 0), 2))));
                    z = w * (d - v * t);
                    v3d.z0 = m * Math.Sin(z);
                    v3d.Encender(canva);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }


        public void Onda3DIntercept(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Black;
            double x, y, z1, z2, d1,d2, m, w, v;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color0 = Color.Red;
                    d1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));

                    z1 = w * (d1 - v * t);
                    z2 = w * (d2 - v * t);

                    v3d.z0 = (m * Math.Sin(z1)) + (m * Math.Sin(z2));
                    v3d.Encender(canva);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }



        public void Onda3DIntercept3(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Black;
            double x, y, z1, z2, z3, d1, d2,d3, m, w, v;
            x = -9;
            m = 0.7;
            w = 1.5;
            v = 9.8;
            do
            {
                y = -6.5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color0 = Color.Red;
                    d1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    d3 = (Math.Sqrt((Math.Pow((x + 1.5), 2)) + (Math.Pow((y + 4), 2))));

                    z1 = w * (d1 - v * t);
                    z2 = w * (d2 - v * t);
                    z3 = w * (d3 - v * t);

                    v3d.z0 = (m * Math.Sin(z1)) + (m * Math.Sin(z2)) + (m * Math.Sin(z3));
                    v3d.Encender(canva);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }





        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;
        private double x1 = -10.5, x2 = 10.5;
        private double y1 = -7.5, y2 = 7.5;
        private void init(double sx, double sy, out double x, out double y)
        {
            x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
            y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;
        }

        private float lagrange(float x, float xo, float xf, float yo, float yf)
        {
            if (yo == 0 && yf == 0) return 0;
            float result = (yo * ((float)(x - xf) / (xo - xf))) + (yf * ((x - xo) / (xf - xo)));
            return result;
        }
    }
}
