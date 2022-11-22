using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App3D
{
    internal class SuperficieR : Vector3D
    {
        public int tipo;
        public void Encender(Bitmap canva)
        {
            switch (tipo)
            {
                case 1:
                    Tipo1(canva);
                    break;
                case 2:
                    Tipo2(canva);
                    break;
                case 3:
                    Tipo3(canva);
                    break;
                default:
                    break;
            }

        }

        private void Tipo1(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            double x = -5; double dx = 0.1;
            

            do
            {
                double y = -3.5; double dy = 0.1;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.z0 = 0.15 * (Math.Pow(x, 2) + Math.Pow(y, 2)) -4;
                    v3d.Encender(canva);
                    y = y + dy;
                }
                while (y <= 3.5);
                x = x + dx;
            }
            while (x <= 5);
        
    }
        private void Tipo2(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            double x = -5; double dx = 0.1;


            do
            {
                double y = -3.5; double dy = 0.1;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.z0 = 0.15 * (Math.Pow(x, 2) - Math.Pow(y, 2)) - 2;
                    v3d.Encender(canva);
                    y = y + dy;
                }
                while (y <= 3.5);
                x = x + dx;
            }
            while (x <= 5);

        }
        private void Tipo3(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            double x = -5; double dx = 0.1;


            do
            {
                double y = -3.5; double dy = 0.1;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.z0 = 0.15 * (Math.Pow(x, 2) - Math.Pow(y, 2)) - 2;
                    v3d.Encender(canva);
                    y = y + dy;
                }
                while (y <= 3.5);
                x = x + dx;
            }
            while (x <= 5);

        }

    }
}
