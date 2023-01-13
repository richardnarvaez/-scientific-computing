using CompuGrafica.App;
using CompuGrafica.App3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuGrafica
{
    public partial class Form1 : Form
    {
        Bitmap bpm = new Bitmap(701, 501);
        int screenSizeX = 700, screenSizeY = 500;
        Margarita margarita = new Margarita();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCleanCanva_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private float lagrange(float x, float xo, float xf, float yo, float yf)
        {
            if (yo == 0 && yf == 0) return 0;
            float result = (yo * ((float)(x - xf) / (xo - xf))) + (yf * ((x - xo) / (xf - xo)));
            return result;
        }

        private void dosColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
                for (int j = 0; j < 500; j++)
                    if (i <= 350)
                        bpm.SetPixel(i, j, Color.FromArgb(250, 204, 21));
                    else
                        bpm.SetPixel(i, j, Color.FromArgb(59, 130, 246));


            canvas.Image = bpm;
        }

        private async void dosColoresConDegradadoToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            float red = 250, green = 204, blue = 21;
            float red_final = 59, green_final = 130, blue_final = 246;
            for (int i = 0; i < 700; i++)
            {
                int red_interpolado = (int)lagrange(i, 0, 700, red, red_final);
                int green_interpolado = (int)lagrange(i, 0, 700, green, green_final);
                int blue_interpolado = (int)lagrange(i, 0, 700, blue, blue_final);

                
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
                await Task.Delay(1);
            }

            
        }

        private void degradadoAMARILLOVERDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < 700; i++)
            {
                int color_range = (255 * (i - 700) / -700);
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(color_range, 255, 0));
                }
            }

            canvas.Image = bpm;
        }

        private void limpiarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bpm = new Bitmap(701, 501);
            canvas.Image = null;
        }

        private void dibujoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            double radio = 15;
            int px = 700 / 2;
            int py = 500 / 2;

            for (int i = px - (int)radio; i <= px + radio; i++)
                for (int j = py - (int)radio; j <= py + radio; j++)
                    if (Math.Abs(Math.Pow(i - px, 2) + Math.Pow(j - py, 2) - Math.Pow(radio, 2)) <= radio)
                        bpm.SetPixel(i, j, Color.Red);
            for (int i = 0; i < px; i++)
                bpm.SetPixel(i, py, Color.Blue);
            bpm.SetPixel(px, py, Color.FromArgb(255, 255, 255));
            canvas.Image = bpm;
        }

        private void encenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            v.Encender(bpm);
            canvas.Image = bpm;

            Vector v1 = new Vector(-4,0, Color.White);
            v1.Encender(bpm);
            canvas.Image = bpm;
        }

        private void dibujarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = 0;
            Vector v = new Vector(-4, 0, Color.White);
            do
            {
                v.x0 = x;
                v.y0 = x;
                v.color0 = Color.Red;
                v.Encender(bpm);
                x += 0.05;
            } while (x<=3);

            canvas.Image = bpm;

           
        }

        private void ligthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.BackColor = Color.White;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.BackColor = Color.FromArgb(3,105,161);
        }

        private void parabolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = -2;
            Vector v = new Vector(-4, 0, Color.White);
            do
            {
                v.x0 = x;
                v.y0 = x * x - 5;
                v.color0 = Color.Black;
                v.Encender(bpm);
                x += 0.05;
            } while (x <= 3);

            canvas.Image = bpm;
        }

        private void encenderSegmentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Segmento s = new Segmento();
            s.x0 = -5;
            s.xf = 2;
            s.y0 = 3;
            s.yf = -3;
            s.color0 = Color.Black;
            s.Encender(bpm);
            canvas.Image = bpm;
        }

        private void crearCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circunferencia s = new Circunferencia();
            s.rd = 2;
            s.x0 = 1;
            s.y0 = 1;
            s.color0 = Color.Red;
            s.Encender(bpm);
            canvas.Image = bpm;
        }

        private void ejesXYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.x0 = -6;
            s.xf = 4;
            s.y0 = 0;
            s.yf = 0;
            s.color0 = Color.Black;
            s.Encender(bpm);
            Segmento sy = new Segmento();
            sy.x0 = 0;
            sy.xf = 0;
            sy.y0 = -4;
            sy.yf = 3;
            sy.color0 = Color.Black;
            sy.Encender(bpm);
            canvas.Image = bpm;
        }

        private void dibujoTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.x0 = -4;
            s.xf = -4;
            s.y0 = -2.5;
            s.yf = 1.4;
            s.color0 = Color.Black;
            s.Encender(bpm);
            s.x0 = -7;
            s.xf = 4;
            s.y0 = 3;
            s.yf = -4;
            s.color0 = Color.Black;
            s.Encender(bpm);
            s.x0 = -7;
            s.xf = 4;
            s.y0 = -4;
            s.yf = 3;
            s.color0 = Color.Black;
            s.Encender(bpm);
            canvas.Image = bpm;

            Circunferencia c1 = new Circunferencia();
            c1.rd = 2;
            c1.x0 = -1.5;
            c1.y0 = 1.90;
            c1.color0 = Color.Red;
            c1.Encender(bpm);
            c1.rd = 0.5;
            c1.x0 = -3;
            c1.y0 = -0.5;
            c1.color0 = Color.Blue;
            c1.Encender(bpm);
            c1.rd = 0.75;
            c1.x0 = 3;
            c1.y0 = 0;
            c1.color0 = Color.Green;
            c1.Encender(bpm);
            canvas.Image = bpm;
        }

        private async void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double rd = 5;
            Vector v = new Vector();
            double t = 0;
            double dt = 0.001;
            do
            {
                double x = 1 * 7 * Math.Sin(t) + 4 * Math.Sin(t * 3.375);
                double y = 5 * 7 * Math.Cos(t) + 4 * Math.Cos(t * 3.375);
                v.x0 = x + (rd * (Math.Cos(t)));
                v.y0 = y + (rd * (Math.Sin(t)));
                //v.x0 = x;
                //v.y0 = y;
                v.color0 = Color.White;
                v.Encender(bpm);

                canvas.Image = bpm;
                //await Task.Delay(1);
                t = t + dt;
            } while (t <= 400);
        }

        private void dibujarLazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lazo s = new Lazo();
            s.rd = 2;
            s.x0 = 0;
            s.y0 = 0;
            s.color0 = Color.Black;
            s.Encender(bpm);

            canvas.Image = bpm;
        }

        private void dibujarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            margarita.rd = 2;
            margarita.x0 = 0;
            margarita.y0 = 0;
            margarita.color0 = Color.Black;
            margarita.Encender(bpm);

            canvas.Image = bpm;
        }

        private void dibujoVariosElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Margarita s = new Margarita();
            Lazo s1 = new Lazo();
            Circunferencia c = new Circunferencia();
            c.rd = 0.3;
            c.x0 = -1;
            c.y0 = 0;
            c.Encender(bpm);
            c.rd = 0.3;
            c.x0 = 1;
            c.y0 = 0;
            c.Encender(bpm);

            s.rd = 1;
            s.x0 = -2;
            s.y0 = -1;
            s.color0 = Color.Black;
            s.Encender(bpm);
            s.rd = 0.5;
            s.x0 = -2;
            s.y0 = 1;
            s.color0 = Color.Gray;
            s.Encender(bpm);
            s.rd = 1;
            s.x0 = 2;
            s.y0 = -1;
            s.color0 = Color.Black;
            s.Encender(bpm);
            s.rd = 0.5;
            s.x0 = 2;
            s.y0 = 1;
            s.color0 = Color.Gray;
            s.Encender(bpm);


            s1.rd = .6;
            s1.x0 = 0;
            s1.y0 = -1.3;
            s1.color0 = Color.Pink;
            s1.Encender(bpm);
            s1.rd = 2;
            s1.x0 = 0;
            s1.y0 = 0;
            s1.color0 = Color.Black;
            s1.Encender(bpm);

            canvas.Image = bpm;
        }

        private void dibujarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double t = -5.5;
            double dt = 0.001;
            Vector v = new Vector();
            float red = 250, green = 204, blue = 21;
            float red_final = 59, green_final = 130, blue_final = 246;
            for (int i = 0; i < 700; i++)
            {
                int red_interpolado = (int)lagrange(i, 0, 700, red, red_final);
                int green_interpolado = (int)lagrange(i, 0, 700, green, green_final);
                int blue_interpolado = (int)lagrange(i, 0, 700, blue, blue_final);


                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
            }

            do {
                v.x0 = t;
                v.y0 = Math.Pow(t, 2)-3;
                v.color0 = Color.Red;
                v.Encender(bpm);
                v.y0 = Math.Pow(2,t);
                v.color0 = Color.Green;
                v.Encender(bpm);
                v.y0 = Math.Sin(t);
                v.color0 = Color.Pink;
                v.Encender(bpm);
                t = t + dt;
            
            } while (t < 5.5);
            canvas.Image = bpm;
        }

        private void dibujarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.x0 = -7;
            s.xf = 7;
            s.y0 = 0;
            s.yf = 0;
            s.color0 = Color.Blue;
            s.Encender(bpm);
            Segmento sy = new Segmento();
            sy.x0 = 0;
            sy.xf = 0;
            sy.y0 = -5;
            sy.yf = 5;
            sy.color0 = Color.Blue;
            sy.Encender(bpm);
            canvas.Image = bpm;
        }

        private  void apagarMargaritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            margarita.Apagar(bpm);
            canvas.Image = bpm;
        }

        private async void onOffMargaritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Margarita s = new Margarita();
            s.rd = 2;
            s.x0 = 0;
            s.y0 = 0;
            s.color0 = Color.Blue;
            while (true)
            {
                s.Encender(bpm);
                canvas.Image = bpm;
                await Task.Delay(1000);
                s.Apagar(bpm);
                canvas.Image = bpm;
                await Task.Delay(1000);
            }
        }

        private void crearLazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lazo s = new Lazo();
            s.rd = 1;
            s.x0 = -5;
            s.y0 = 0;
            s.color0 = Color.Black;
            while (s.x0 < 5) {
                s.x0 = s.x0 + 0.3;
                s.Encender(bpm);
                canvas.Image = bpm;
            }
        }

        private async void animacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lazo s = new Lazo();
            s.rd = 1;
            s.x0 = -5;
            s.y0 = 0;
            s.color0 = Color.Black;
            while (s.x0 < 5)
            {
                s.x0 = s.x0 + 0.1;
                s.y0 = s.x0 / 2;
                s.Encender(bpm);
                canvas.Image = bpm;
                await Task.Delay(25);
                s.Apagar(bpm);
                canvas.Image = bpm;
            }
        }

        private async void pRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float red = 250, green = 204, blue = 21;
            float red_final = 255, green_final = 255, blue_final = 255;
            for (int i = 0; i < 700/2; i++)
            {
                int red_interpolado = (int)lagrange(i, 0, 700/2, red, red_final);
                int green_interpolado = (int)lagrange(i, 0, 700/2, green, green_final);
                int blue_interpolado = (int)lagrange(i, 0, 700/2, blue, blue_final);
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
                // await Task.Delay(1);
            }

            red = 255; green = 255; blue = 255;
            red_final = 250; green_final = 204; blue_final = 21;
            for (int i = 375; i < 700; i++)
            {
                int red_interpolado = (int)lagrange(i, 375, 700, red, red_final);
                int green_interpolado = (int)lagrange(i, 375, 700, green, green_final);
                int blue_interpolado = (int)lagrange(i, 375, 700, blue, blue_final);
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
                // await Task.Delay(1);
            }

        }

        private void cORRECCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float red = 100, green = 100, blue = 150;
            float red_final = 255, green_final = 255, blue_final = 255;
            for (int i = 0; i < 700 / 2; i++)
            {
                int red_interpolado = (int)lagrange(i, 0, 700 / 2, red, red_final);
                int green_interpolado = (int)lagrange(i, 0, 700 / 2, green, green_final);
                int blue_interpolado = (int)lagrange(i, 0, 700 / 2, blue, blue_final);
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
                // await Task.Delay(1);
            }

            red = 255; green = 255; blue = 255;
            red_final = 100; green_final = 100; blue_final = 150;
            for (int i = 375; i < 700; i++)
            {
                int red_interpolado = (int)lagrange(i, 375, 700, red, red_final);
                int green_interpolado = (int)lagrange(i, 375, 700, green, green_final);
                int blue_interpolado = (int)lagrange(i, 375, 700, blue, blue_final);
                for (int j = 0; j < 500; j++)
                {
                    bpm.SetPixel(i, j, Color.FromArgb(red_interpolado, green_interpolado, blue_interpolado));
                }
                canvas.Image = bpm;
                // await Task.Delay(1);
            }
        }

        private void pruebaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double t = 0;
            double dt = 0.002;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Goldenrod;
            do
            {
                v3d.x0 = 1  + 3 *Math.Cos(t);
                v3d.y0 = -2 + 3 * Math.Sin(t);
                v3d.z0 = 2;
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 6);
            canvas.Image = bpm;
        }

        private void circunferenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double t = 0;
            double dt = 0.002;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Goldenrod;
            do
            {
                v3d.x0 = 3 * Math.Sin(t);
                v3d.y0 = -3;
                v3d.z0 = 3 * Math.Cos(t);
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 6);
            canvas.Image = bpm;
        }

        private void tresComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double t = 0;
            double dt = 0.002;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Goldenrod;
            do
            {
                v3d.x0 = 3 * Math.Sin(t);
                v3d.y0 = 3 * Math.Cos(t);
                v3d.z0 = t/5;
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 15);
            canvas.Image = bpm;
        }

        private void tresEspiralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double t = 0;
            double dt = 0.002;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Goldenrod;
            do
            {
                v3d.x0 = .5 * Math.Sin(t);
                v3d.y0 = .5 * Math.Cos(t);
                v3d.z0 = (t / 30)-1;
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 200);
            canvas.Image = bpm;
            t = 0;
            v3d.color0 = Color.Red;
            do
            {
                v3d.x0 = 1 * Math.Sin(t) + 3;
                v3d.y0 = 1 * Math.Cos(t) + 3;
                v3d.z0 = (t / 50)-2;
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 300);
            canvas.Image = bpm;
            t = 0;
            v3d.color0 = Color.Blue;
            do
            {
                v3d.x0 = 1.5 * Math.Sin(t) - 3;
                v3d.y0 = 1.5 * Math.Cos(t) - 3;
                v3d.z0 = t / 30;
                v3d.Encender(bpm);
                t = t + dt;
            }
            while (t <= 100);
            

        }

        private void encenderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Segmento3D segmento3D = new Segmento3D();
            segmento3D.x0 = 0; segmento3D.xf = 4;
            segmento3D.y0 = 0; segmento3D.yf = 5;
            segmento3D.z0 = 0; segmento3D.zf = 2;

            segmento3D.Encender(bpm);
            canvas.Image = bpm;

            
        }

        private void ejesXYZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento3D xyz = new Segmento3D();
            xyz.color0 = Color.Black;
            xyz.x0 = 0; xyz.xf = 8;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);

            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 0; xyz.yf = 5;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);
            

            //Eje Y REAL
            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 0; xyz.zf = 4;

            xyz.Encender(bpm);
            /*xyz.z0 = 0; xyz.zf = 0;
            xyz.color0 = Color.FromArgb(204, 208,213);
            xyz.x0 = -8; xyz.xf = 0;
            xyz.Encender(bpm);
            xyz.x0 = 0;
            xyz.y0 = -4; xyz.yf = 0;
            xyz.Encender(bpm);
            xyz.y0 = 0;
            xyz.z0 = -4; xyz.zf = 0;
            xyz.Encender(bpm); */


            canvas.Image = bpm;
        }

        private void espacio3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segmento3D xyz = new Segmento3D();
            xyz.color0 = Color.Black;
            xyz.x0 = 0; xyz.xf = 8.5;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);

            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 0; xyz.yf = 5.5;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);


            //Eje Y REAL
            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 0; xyz.zf = 4.5;

            xyz.Encender(bpm);

            // OTROS

            xyz.color0 = Color.FromArgb(204, 208, 213);

            xyz.x0 = 0; xyz.xf = 8;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 4; xyz.zf = 4;

            xyz.Encender(bpm);

            xyz.x0 = 8; xyz.xf = 8;
            xyz.y0 = 0; xyz.yf = 0;
            xyz.z0 = 0; xyz.zf = 4;

            xyz.Encender(bpm);


            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 0; xyz.yf = 5;
            xyz.z0 = 4; xyz.zf = 4;

            xyz.Encender(bpm);


            xyz.x0 = 0; xyz.xf = 0;
            xyz.y0 = 5; xyz.yf = 5;
            xyz.z0 = 0; xyz.zf = 4;

            xyz.Encender(bpm);

            // ABAJO
            xyz.x0 = 8; xyz.xf = 8;
            xyz.y0 = 0; xyz.yf = 5;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);

            xyz.x0 = 0; xyz.xf = 8;
            xyz.y0 = 5; xyz.yf = 5;
            xyz.z0 = 0; xyz.zf = 0;

            xyz.Encender(bpm);
           
            canvas.Image = bpm;
        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void cilindroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuperficieV v = new SuperficieV();
            v.rd = 2;
            v.tipo = 1;

            v.Encender(bpm);
            canvas.Image = bpm;
        }

        private void tipo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV v = new SuperficieV();
            v.rd = 2;
            v.tipo = 2;
            v.z0 = 0;
            v.Encender(bpm);
            canvas.Image = bpm;
        }

        private void primeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieR r = new SuperficieR();
            r.tipo = 1;
            r.color0 = Color.Black;
            r.Encender(bpm);
            canvas.Image = bpm;
        }

        private void segundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieR r = new SuperficieR();
            r.tipo = 2;
            r.color0 = Color.White;
            r.Encender(bpm);
            canvas.Image = bpm;
        }

        private void terceroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tipo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV v = new SuperficieV();
            v.rd = 1;
            v.tipo = 3;
            v.z0 = -1;
            v.Encender(bpm);
            canvas.Image = bpm;
        }

        private void t4HiperboloideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperficieV v = new SuperficieV();
            v.rd = 1;
            v.tipo = 4;
            v.z0 = Math.PI;
            v.y0 = 1.6;
            v.Encender(bpm);
            canvas.Image = bpm;
        }

        private void primeroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color[] paleta = new Color[16];
            paleta[0] = Color.Black;
            paleta[1] = Color.Navy;
            paleta[2] = Color.Green;
            paleta[3] = Color.Aqua;
            paleta[4] = Color.Red;
            paleta[5] = Color.Purple;
            paleta[6] = Color.Maroon;
            paleta[7] = Color.LightGray;
            paleta[8] = Color.DarkGray;
            paleta[9] = Color.Blue;
            paleta[10] = Color.Lime;
            paleta[11] = Color.Silver;
            paleta[12] = Color.Teal;
            paleta[13] = Color.Fuchsia;
            paleta[14] = Color.Yellow;
            paleta[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++) {
                for (int j = 0; j < 500; j++) {
                    colorT = (i*i + j*j)%15;
                    c= paleta[colorT];
                    bpm.SetPixel(i, j, c);
                }
            }

            canvas.Image = bpm;
        }

        private async void segundoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color[] paleta = new Color[16];
            paleta[0] = Color.Black;
            paleta[1] = Color.Navy;
            paleta[2] = Color.Green;
            paleta[3] = Color.Aqua;
            paleta[4] = Color.Red;
            paleta[5] = Color.Purple;
            paleta[6] = Color.Maroon;
            paleta[7] = Color.LightGray;
            paleta[8] = Color.DarkGray;
            paleta[9] = Color.Blue;
            paleta[10] = Color.Lime;
            paleta[11] = Color.Silver;
            paleta[12] = Color.Teal;
            paleta[13] = Color.Fuchsia;
            paleta[14] = Color.Yellow;
            paleta[15] = Color.White;

            int colorT;
            Color c;
            double transform = 3;
            for (int fps=0; fps<=100; fps++)
            {
                
                
                for (int i = 0; i < 700; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        // READY
                        //colorT = Math.Abs((int)( Math.Sin(i) + 4 * Math.Sin(j * 3.375)) % 15);

                        //TRIANGULO
                        // colorT = Math.Abs((int)(Math.Sinh(i)* Math.Cosh(j)) % 15);
                        // colorT = Math.Abs((int)((i)*15) / 700);
                        // colorT = Math.Abs((int)(Math.Sin(i) + Math.Pow(j,2)) %10);
                        // colorT = Math.Abs((int)(Math.Sin(i) + Math.Sqrt(j*j + i*i)) % 10);

                        // ONDA
                        // colorT = Math.Abs((int)(Math.Sqrt(j * j + i * i) ) % 14);
                        // colorT = Math.Abs((int)(Math.Sqrt(i* i + j *j + Math.Sin(x)) )% 16);
                        // c = paleta[colorT % 3 == 0 ? 1 : 3];
                        // colorT = Math.Abs((int)(Math.Sqrt(i * i) + Math.Sin(j)) % 4);

                        // OTRO
                        // colorT = Math.Abs((int)(Math.Sin(i)+ 4  * Math.Sin(j * 3.2)) % 15);

                        // El mejor
                        colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * 3.3333)) % 15);
                        // colorT = Math.Abs((int)(Math.Sin(i*j) +3  * Math.Sin(j *3.3333 + Math.Sqrt(i))) % 15);
                        // colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * 3.11111 + Math.Sqrt(i))));
                        // FINAL
                        // colorT = Math.Abs((int)(Math.Sin(i * j) + 3 * Math.Sin(j * transform + Math.Sqrt(i))));
                        c = paleta[colorT];
                        bpm.SetPixel(i, j, c);

                        
                    }
                }
                canvas.Image = bpm;
                transform += 0.001212121;
                await Task.Delay(10);
            }
            
            
        }

        private void claseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color[] paleta = new Color[16];
            for (int i = 0; i < paleta.Length; i++) {
                int green_interpolado = (int)lagrange(i, 0, 15, 90, 130);
                paleta[i] = Color.FromArgb(180, green_interpolado, 40);
            }
            // paleta[0] = Color.FromArgb(180, 90, 40);
            // paleta[15] = Color.FromArgb(180, 130, 40);

            int colorT;
            Color c;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(Math.Sqrt(i) * j / 100)%15;
                    c = paleta[colorT];
                    bpm.SetPixel(i, j, c);
                }
            }
            canvas.Image = bpm;
        }

        private void nieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color[] paleta = new Color[16];
            /*for (int i = 0; i < paleta.Length; i++)
            {
                int green_interpolado = (int)lagrange(i, 0, 15, 0, 137);
                paleta[i] = Color.FromArgb(107, green_interpolado, 187);
            }*/
            paleta[0] = Color.FromArgb(107, 137, 187);
            paleta[1] = Color.FromArgb(52, 90, 138);
            paleta[2] = Color.FromArgb(255, 255, 255);
            paleta[3] = Color.FromArgb(214, 222, 250);

            int colorT;
            Color c;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    colorT = (int)(Math.E * (i / 2) + Math.PI * (Math.Pow(j, 2)) + j * i) % 6;
                    c = paleta[colorT];
                    bpm.SetPixel(i, j, c);
                }
            }
            canvas.Image = bpm;
        }

        private void piedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color[] paleta = new Color[16];
            /*for (int i = 0; i < paleta.Length; i++)
            {
                int green_interpolado = (int)lagrange(i, 0, 15, 0, 137);
                paleta[i] = Color.FromArgb(107, green_interpolado, 187);
            }*/
            paleta[0] = Color.FromArgb(224, 244, 244);
            paleta[1] = Color.FromArgb(136, 134, 134);
            paleta[2] = Color.FromArgb(255, 255, 255);
            paleta[3] = Color.FromArgb(136, 136, 136);

            int colorT;
            Color c;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)((Math.Pow(i * (j + 70), 7) + Math.Pow(j * i * 2 / 2.5, 2)) % 15 + 1);
                    c = paleta[colorT];
                    bpm.SetPixel(i, j, c);
                }
            }
            canvas.Image = bpm;
        }

        private void dibujoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double x = -6;
            double y = 0;
            Vector vector = new Vector();
            do
            {
                y = -((x - 6) * (x + 6)) / 9;
                
                vector.x0 = x;
                vector.y0 = y;
                vector.Encender(bpm);
                x += 0.01;
                // bpm.SetPixel(x, y, Color.Black);

            } while (x <= 6);
            canvas.Image = bpm;
        }

        private async void animacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double x = -6;
            double y = 0;
            Vector vector = new Vector();

            Circunferencia s = new Circunferencia();
            for (int i = 0; i <= 100; i++)
            {
                do
                {
                    y = -((x - 6) * (x + 6)) / 9;

                    canvas.Image = bpm;
                    s.rd = 0.5;
                    s.x0 = x;
                    s.y0 = y;
                    s.color0 = Color.Red;
                    s.Encender(bpm);

                    vector.x0 = x;
                    vector.y0 = y;
                    vector.Encender(bpm);
                    x += 0.01;

                    // bpm.SetPixel(x, y, Color.Black);

                } while (x <= 6);
                canvas.Image = bpm;
                await Task.Delay(1);
            }   
    }

        private async void rebotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector vec = new Vector();
            
            Circunferencia s = new Circunferencia();
            s.rd = 0.1;
            s.x0 = -6;
            s.y0 = 0;
            s.color0 = Color.Black;
           
                s.x0 = s.x0 + 0.2;
                
                double t = -6, dt = 0.001;

            do
            {
                vec.x0 = t;
                vec.y0 = -(t + 3) * (t + 6) * 1.3;
                vec.Encender(bpm);
                t = t + dt;
                

            } while (t <= -3);
            t = -3;

            do
            {
                vec.x0 = t;
                vec.y0 = -(t + 1) * (t + 3) * 1.5;
                vec.Encender(bpm);
                t = t + dt;
                
            } while (t <= -1);
            t = -1;

            do
            {
                vec.x0 = t;
                vec.y0 = (-(t - 0) * (t + 1)) * 2;
                vec.Encender(bpm);
                t = t + dt;
               
            } while (t <= 0);
            t = 0;

            do
            {
                vec.x0 = t;
                vec.y0 = (-(t - 0) * (t - 0.5)) * 1.5;
                vec.Encender(bpm);
                t = t + dt;
               
            } while (t <= 0.5);

            dt = 0.01;


            t = -6;
            // ASSDASDASDASDASD

            do
            {
                    vec.x0 = t;
                    vec.y0 = -(t + 3) * (t + 6) * 1.3;
                    vec.Encender(bpm);
                    t = t + dt;
                    canvas.Image = bpm;
                    s.y0 = vec.y0;
                    s.x0 = vec.x0;
                    s.Encender(bpm);
                    await Task.Delay(1);
                    s.Apagar(bpm);

            } while (t <= -3);
                t = -3;
               
            do
                {
                    vec.x0 = t;
                    vec.y0 = -(t + 1) * (t + 3) * 1.5;
                    vec.Encender(bpm);
                    t = t + dt;
                canvas.Image = bpm;
                s.y0 = vec.y0;
                s.x0 = vec.x0;
                s.Encender(bpm);
                await Task.Delay(1);
                s.Apagar(bpm);
            } while (t <= -1);
                t = -1;
               
            do
                {
                    vec.x0 = t;
                    vec.y0 = (-(t - 0) * (t + 1)) * 2;
                    vec.Encender(bpm);
                    t = t + dt;
                canvas.Image = bpm;
                s.y0 = vec.y0;
                s.x0 = vec.x0;
                s.Encender(bpm);
                await Task.Delay(1);
                s.Apagar(bpm);
            } while (t <= 0);
                t = 0;
               
            do
                {
                    vec.x0 = t;
                    vec.y0 = (-(t - 0) * (t - 0.5)) * 1.5;
                    vec.Encender(bpm);
                    t = t + dt;
                canvas.Image = bpm;
                s.y0 = vec.y0;
                s.x0 = vec.x0;
                s.Encender(bpm);
                await Task.Delay(1);
                s.Apagar(bpm);
            } while (t <= 0.5);


           


           
            // await Task.Delay(25);

            //   canvas.Image = bpm;
            

        }

        private void primeroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double x = -7;
            double y = 0;
            Vector vector = new Vector();
            vector.color0 = Color.White;
            do
            {
                y = -((x - 7) * (x + 7)) / 18;

                vector.x0 = x;
                vector.y0 = y;
                vector.Encender(bpm);
                x += 0.01;
                // bpm.SetPixel(x, y, Color.Black);

            } while (x <= 7);
            canvas.Image = bpm;

            

        }

        private void canvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            // Console.WriteLine("EVENTO2", coordinates.X, coordinates.Y);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("EVENTO 2: " +  e.X  + "  "+  e.Y);
            Circunferencia cir = new Circunferencia();
            double x = 0; double y = 0;
            init(e.X, e.Y, out x, out y);
            Console.WriteLine("EVENTO 2: REAL: " + x + "  " +y);
            cir.color0 = Color.White;
            cir.x0 = x;
            cir.y0 = y;
            cir.rd = 0.1;
            cir.Encender(bpm);
            canvas.Image = bpm;
            // rayo
            Segmento s = new Segmento();
            s.color0 = Color.Yellow;
            s.x0 = x;
            s.y0 = y;
            double хFinal = x;
            double yfinal = -(((x + 7) * (x - 7)) / 18);
            s.xf = хFinal;
            s.yf = yfinal;
            s.Encender(bpm);

            s.color0 = Color.Red;
            s.x0 = x;
            s.y0 = -(((x + 7) * (x - 7)) / 18);
            хFinal = 7;
            if (x < 0) {
                хFinal = 7;
                yfinal = (9 / x) * (7 - x) + y;
            }
            else {
                хFinal = -7;
                yfinal = (9 / x) * (-7 - x) + y;
            }
            s.xf = хFinal;
            s.yf = yfinal;
            s.Encender(bpm);
            canvas.Image = bpm;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("EVENTO 1", e.X);
           
        }

        private void onePixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bpm.SetPixel(screenSizeX/2, screenSizeY/2, Color.FromArgb(255, 255, 255));
            canvas.Image = bpm;
        }


        private void pruebaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
  
        }
        
    private async void pruebaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private double y1 = -5, y2 = 5;


        public static int sx1 = 0;
        public static int sy1 = 0;
        public static int sx2 = 700;
        public static int sy2 = 500;

        private void ondaColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda objO = new Onda();

            objO.t = 1;
            objO.GrafO(bpm);
            canvas.Image = bpm;
        }

        private void ondaGRISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda objO = new Onda();
            objO.t = 1;
            objO.GrafO(bpm);
            canvas.Image = bpm;

        }

        private async void pruebaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.x0 = -2;
            c.y0 = -2;
            c.rd = 2;
            c.color0 = Color.Red;
            c.Encender(bpm);
            canvas.Image = bpm;

            Segmento vec = new Segmento();
            vec.color0 = Color.Black;
            vec.x0 = -2;
            vec.y0 = -2;
            // animación
            double t = 0.05;
            double r = 4;
            do
            {
                vec.xf = -2 + 1.9 * (double)Math.Sin(t);
                vec.yf = -2 + 1.9 * (double)Math.Cos(t);
                vec.Encender(bpm);
                canvas.Image = bpm;
                await Task.Delay(100);

                vec.Apagar(bpm);
                canvas.Image = bpm;
                t += 0.1;

            } while (t <= (2 * Math.PI * 4));
        }

        private async void correccionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int centroX = 2, centroY = 1;
            Circunferencia c = new Circunferencia();
            c.x0 = centroX;
            c.y0 = centroY;
            c.rd = 2;
            c.color0 = Color.Red;
            c.Encender(bpm);
            canvas.Image = bpm;

            Segmento vec = new Segmento();
            vec.color0 = Color.Black;
            vec.x0 = centroX;
            vec.y0 = centroY;
            // animación
            double t = 0.05;
            double r = 4;
            do
            {
                vec.xf = centroX + 1.9 * (double)Math.Sin(t);
                vec.yf = centroY + 1.9 * (double)Math.Cos(t);
                vec.Encender(bpm);
                canvas.Image = bpm;
                await Task.Delay(100);

                vec.Apagar(bpm);
                canvas.Image = bpm;
                t += 0.1;

            } while (t <= (2 * Math.PI * 4));
        }

        private void interferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda objO = new Onda();

            objO.t = 1;
            objO.GrafoInterferencia(bpm);
            canvas.Image = bpm;
        }

        private void interferencia3FuntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda objO = new Onda();

            objO.t = 1;
            objO.GrafoInterferencia3(bpm);
            canvas.Image = bpm;
            Circunferencia cir = new Circunferencia();
            cir.color0 = Color.White;
            cir.x0 = -1.5;
            cir.y0 = -4;
            cir.rd = 0.2;
            cir.Encender(bpm);


            cir.x0 = 0;
            cir.y0 = 3;
            cir.rd = 0.2;
            cir.Encender(bpm);

            cir.x0 = 0;
            cir.y0 = -3;
            cir.rd = 0.2;
            cir.Encender(bpm);
            canvas.Image = bpm;
        }

        private async void animacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double t = 0;
            Onda objO = new Onda();
            //objO.w = 1.5;
            //objO.v = 9.3;
            objO.t = 0;
            do
            {
                objO.GrafoInterferencia(bpm);

                t += 0.02;
                objO.t = t;
                await Task.Delay(100);

                canvas.Image = bpm;

            } while (t <= 6 * Math.PI);
        }

        private async void animacion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double t = 0;
            Onda objO = new Onda();
            //objO.w = 1.5;
            //objO.v = 9.3;
            objO.t = 0;
            do
            {
                objO.GrafoInterferencia3(bpm);

                t += 0.02;
                objO.t = t;
                await Task.Delay(100);

                canvas.Image = bpm;

            } while (t <= 6 * Math.PI);
        }

        private async void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            double t = 0;
           /* do
            {*/
                onda.t = t;
                onda.Onda3D(bpm);
                canvas.Image = bpm;

        /*        canvas.Refresh();
                bpm = null;
                bpm = new Bitmap(701, 501);
                await Task.Delay(100);

                t += 0.01;
            }
            while (t <= 4);*/
        }

        private void interceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            double t = 0;
            onda.t = t;
            onda.Onda3DIntercept(bpm);
            canvas.Image = bpm;
        }

        private void interferencia3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            double t = 0;
            onda.t = t;
            onda.Onda3DIntercept3(bpm);
            canvas.Image = bpm;
        }

        private async void animNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            double t = 0;
            do { 
            onda.t = t;
            onda.Onda3D(bpm);
            canvas.Image = bpm;

                canvas.Refresh();
                    bpm = null;
                    bpm = new Bitmap(701, 501);
                    await Task.Delay(100);

                    t += 0.01;
                }
                while (t <= 4);
        }

        private async void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            double t = 0;

            do
            {
                onda.t = t;
                onda.Onda3D(bpm);
                canvas.Image = bpm;

                canvas.Refresh();
                bpm = null;
                bpm = new Bitmap(701, 501);
                await Task.Delay(100);

                t += 0.01;
            }
            while (t <= 1);

           
            do
            {
                onda.t = t;
                onda.Onda3DIntercept3(bpm);
                canvas.Image = bpm;

                canvas.Refresh();
                bpm = null;
                bpm = new Bitmap(701, 501);
                await Task.Delay(100);

                t += 0.01;
            }
            while (t <= 4);
        }

        private double x1 = -7, x2 = 7;
        private void init(double sx, double sy, out double x, out double y)
        {
            x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
            y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;
        }

    }
}
