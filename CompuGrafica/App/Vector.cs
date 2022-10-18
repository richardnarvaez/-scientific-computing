using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App
{
    internal class Vector
    {
        public double x0;
        public double y0;
        public Color color0 = Color.Red;

        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;

        private double x1 = -7, x2 = 5;
        private double y1 = -5, y2 = 4;

        public Vector() { 
        }
        public Vector(double x0, double y0, Color color0) {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }
        public void Encender(Bitmap canva)
        {
            int sX;
            int sY;

            Pantalla(x0, y0, out sX, out sY);

            if (sX >= 0 && sX < 700 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, color0);
            }
        }


        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
    }
    
}
