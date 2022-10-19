using CompuGrafica.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            canvas.BackColor = Color.Black;
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

        private void onePixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bpm.SetPixel(screenSizeX/2, screenSizeY/2, Color.FromArgb(255, 255, 255));
            canvas.Image = bpm;
        }
    }
}
