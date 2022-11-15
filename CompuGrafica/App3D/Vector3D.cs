using CompuGrafica.App;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App3D
{
    internal class Vector3D : Vector
    {
        public double z0;

        public Vector3D()
        {

        }

        private void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            double alpha = 0.785;
            ax = y - (x / 2) * Math.Cos(alpha);
            ay = z - (x / 2) * Math.Sin(alpha);
        }

        public void Encender(Bitmap canva)
        {
            double ax;
            double ay;
            int sx;
            int sy;
            Axonometria(x0, y0, z0, out ax, out ay);
            Pantalla screen = new Pantalla();
            screen.init(ax, ay, out sx, out sy);
            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 500)
            {
                canva.SetPixel(sx, sy, color0);
            }
        }
    }
}