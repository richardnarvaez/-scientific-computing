using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App3D
{
    internal class Segmento3D : Vector3D
    {
        public double xf;
        public double yf;
        public double zf;

        public void Encender(Bitmap canva)
        {
            double t = 0;
            double dt = 0.00001;
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            do
            {
                v3d.x0 = (x0 + (xf - x0) * t); // x0 * (1 - t) + xf * t;
                v3d.y0 = (y0 + (yf - y0) * t); // y0 * (1 - t) + yf * t;
                v3d.z0 = z0 + (zf - z0) * t; // z0 * (1 - t) + zf * t;
                v3d.Encender(canva);
                t = t + dt;
            }
            while (t <= 1);
        }
    }
}
