using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App
{
    internal class Circunferencia : Vector
    {
        public double rd;

        public Circunferencia() {
        
        }

        public void Encender(Bitmap canva)
        {
            Vector v = new Vector();
            double t = 0;
            double dt = 0.001;
            do
            {
                v.x0 = x0 + (rd * (Math.Cos(t)));
                v.y0 = y0 + (rd * (Math.Sin(t)));
                v.color0 = color0;
                v.Encender(canva);
                t = t + dt;
            } while (t <= (2 * Math.PI));
        }

        public void Apagar(Bitmap canva)
        {
            Vector v = new Vector();
            double t = 0;
            double dt = 0.001;
            do
            {
                v.x0 = x0 + (rd * (Math.Cos(t)));
                v.y0 = y0 + (rd * (Math.Sin(t)));
                v.Apagar(canva);
                t = t + dt;
            } while (t <= (2 * Math.PI));
        }
    }
}
