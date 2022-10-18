using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App
{
    internal class Pantalla
    {
        private int x1 =-7, x2= 5;
        private int y1 = -5, y2=4;
        private int sx1;

        public Pantalla(double x, double y, out int sx, out int sy) {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - x2)) + sx1;
            sy = (int)(((x - x1) / (x1 - x2)) * (sx1 - x2)) + sx1;
        }
    }
}
