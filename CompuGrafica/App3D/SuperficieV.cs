using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuGrafica.App3D
{
    internal class SuperficieV : Vector3D
    {
        public int tipo;
        public double rd;

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
                case 4:
                    Tipo4(canva);
                    break;
                default:
                    break;
            }

        }

        private void Tipo1(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            double t = 0;
            double dt = 0.02;
            do
            {
                double h = 0;
                double dh = 0.2;
                do
                {
                    v3d.x0 = x0 + rd * Math.Cos(t);
                    v3d.y0 = y0 + rd * Math.Sin(t);
                    v3d.z0 = z0 + h;
                    v3d.Encender(canva);
                    h = h + dh;
                }
                while (h <= 4);
                t += dt;
            }
            while (t <= 2 * Math.PI);
        }
        private void Tipo2(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            float distanciaTotal = 3.1416f / 2f;
            float t = -distanciaTotal;
            float dt = 0.2f;

            v3d.color0 = Color.Red;

            do
            {
                float h = 0, dh = 0.02f;

                do
                {
                    v3d.x0 = x0 + (rd * Math.Cos(t) * Math.Cos(h));
                    v3d.y0 = y0 + (rd * Math.Cos(t) * Math.Sin(h));
                    v3d.z0 = z0 + (rd * Math.Sin(t));
                    v3d.Encender(canva);
                    h += dh;
                } while (h <= 2 * Math.PI);

                t += dt;

            } while (t <= distanciaTotal);
        }

        private void Tipo3(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            v3d.color0 = color0;
            double t = 0;
            double dt = 0.1;
            double h, dh;
            do
            {
                h = 0;
                dh = 0.15;
                do
                {
                    v3d.x0 = x0 + rd * (3 + Math.Cos(t)) * Math.Cos(h);
                    v3d.y0 = y0 + rd * (3 + Math.Cos(t)) * Math.Sin(h);
                    v3d.z0 = z0 + rd + Math.Sin(t);
                    v3d.Encender(canva);
                    h += +dh;
                } while (h <= (2 * Math.PI));
                t += dt;
            } while (t <= (2 * Math.PI));
        }
        private void Tipo4(Bitmap canva)
        {
            Vector3D v3d = new Vector3D();
            double t = - Math.PI / 2f;
            float dt = 0.04f;

            v3d.color0 = color0;
            do
            {
                double h = 0, dh = 0.002f;
                do
                {
                    v3d.x0 = x0 + (rd * Math.Cosh(t) * Math.Cos(h));
                    v3d.y0 = y0 + (rd * Math.Cosh(t) * Math.Sin(h));
                    v3d.z0 = z0 + (rd * Math.Sinh(t) -2);
                    v3d.Encender(canva);
                    h += +dh;
                } while (h <= (2 * Math.PI));
                t += +dt;
            } while (t <= Math.PI/2);
        }

    }
}
