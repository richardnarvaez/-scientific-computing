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

        // private double x1 = -70, x2 = 70;
        // private double y1 = -50, y2 = 50;
         private double factorCon = 1.4;
         private double x1 = -10.5, x2 = 10.5; // 7
         private double y1 = -7.5, y2 = 7.5; //5
        public Pantalla() { }

        public void init(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
    }
}
