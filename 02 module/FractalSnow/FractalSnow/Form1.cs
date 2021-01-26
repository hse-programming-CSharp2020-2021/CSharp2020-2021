using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalSnow
{
    public partial class Form1 : Form
    {
        static Pen pen1;
        static Graphics gr;
        static Pen pen2;
        static int iter = 3;
        static int max = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            pen1 = new Pen(Color.Black, 1);
            pen2 = new Pen(Color.White, 1);
            gr.Clear(Color.White);
        }

        //Рекурсивная функция отрисовки фрактала
        static int Fractal(PointF p1, PointF p2, PointF p3, int n)
        {
            if (n == max)
            {
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p2, p3);
                gr.DrawLine(pen1, p3, p1);

                Fractal(p1, p2, p3, n - 1);
                Fractal(p2, p3, p1, n - 1);
                Fractal(p3, p1, p2, n - 1);
            } else if (n > 0) 
            {
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

                gr.DrawLine(pen1, p4, pn);
                gr.DrawLine(pen1, p5, pn);
                gr.DrawLine(pen2, p4, p5);

                Fractal(p4, pn, p5, n - 1);
                Fractal(pn, p5, p4, n - 1);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), n - 1);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, 
                    (2 * p2.Y + p3.Y) / 3), n - 1);

            }
            return n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = iter = int.Parse(textBox1.Text);
            gr.Clear(Color.White);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            Fractal(new PointF(w / 2, h / 5),
                new PointF((float)(w/2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), 
                new PointF((float)(w/2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                iter);
        }
    }
}
