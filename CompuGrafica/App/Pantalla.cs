using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App
{
    internal class Pantalla
    {
        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;

        private double x1 = -7, x2 = 5;
        private double y1 = -5, y2 = 4;

        public Pantalla() { }

        public void init(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
    }
}
