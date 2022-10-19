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

            Pantalla screen = new Pantalla();
            screen.init(x0, y0, out sX, out sY);

            if (sX >= 0 && sX < 700 && sY >= 0 && sY < 500)
            {
                canva.SetPixel(sX, sY, color0);
            }
        }

    }
    
}
