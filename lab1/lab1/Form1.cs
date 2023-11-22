using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {

        static public Point Center;
        public static int R = 100, r = 30;
        public static double omega = 0.5;
        private double t = 0;
        Graphics g = null;
        bool fl = false;
        List<Point> myListA = null;
        List<Point> myListB = null;
        static public Point Pos;

        public Form1()
        {
            InitializeComponent();
            myListA = new List<Point>();
            myListB = new List<Point>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, menuStrip1.ClientSize.Height);
            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height - panel1.Height - menuStrip1.ClientSize.Height;
            Center.X = pictureBox1.Width / 2;
            Center.Y = pictureBox1.Height / 2;
            g = pictureBox1.CreateGraphics();
            Lr1.Text = Convert.ToString(R) + " см";
            Lr2.Text = Convert.ToString(r) + " см";
            LOmega.Text = Convert.ToString(omega) + " рад/с";
            timer1.Interval = (int)(100 / omega);
        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int l = R - r;
            t = 0;
            Picture(true, g);
            стеретьToolStripMenuItem.Enabled = true;
            начатьToolStripMenuItem.Enabled = true;
            //нельзя новый рисунок, пока его не стерли
            нарисоватьToolStripMenuItem.Enabled = false;
            Font myF = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush SBr = new SolidBrush(Color.Black);
            g.DrawString("A", myF, SBr, Center.X + R, Center.Y + R);
            g.DrawString("B", myF, SBr, Center.X + l, Center.Y + r);
            SBr.Dispose();
            fl = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Dispose();
            Close();
        }

        private void Picture(bool cl, Graphics g)
        {
            int l = R - r;

            //неподвижное колесо
            HatchBrush Br = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Black, Color.White);
            Pen p = new Pen(Color.White);
            Rectangle Rect = new Rectangle(Center.X - R, Center.Y + 4 * R / 5, 2 * R, R + 10 - (4 * R / 5));
            g.FillRectangle(Br, Rect);
            g.DrawRectangle(p, Rect);
            p.Color = Color.Black;
            SolidBrush SBr = new SolidBrush(Color.White);
            Rect.Location = new Point(Center.X - R, Center.Y - R);
            Rect.Size = new Size(2 * R, 2 * R);
            g.FillEllipse(SBr, Rect);
            g.DrawEllipse(p, Rect);

            //рисование подшипника
            p.DashStyle = DashStyle.Solid;

            // линии подшипника
            Point tochka = new Point(Center.X - 3, Center.Y + 6);
            g.DrawLine(p, tochka, Center);
            tochka.X = Center.X + 3;
            tochka.Y = Center.Y + 6;
            g.DrawLine(p, Center, tochka);

            // штриховка
            p.Color = Color.White;
            Rect.Location = new Point(Center.X - 10, Center.Y + 6);
            Rect.Size = new Size(20, 5);
            g.FillRectangle(Br, Rect);
            g.DrawRectangle(p, Rect);
            p.Color = Color.Black;
            g.DrawLine(p, Center.X + 5, Center.Y + 6, Center.X - 5, Center.Y + 6);

            //  подшипник
            Rect.Location = new Point(Center.X - 3, Center.Y - 3);
            Rect.Size = new Size(4, 4);
            g.FillEllipse(SBr, Rect);
            g.DrawEllipse(p, Rect);
            Br.Dispose();
            p.Dispose();
            SBr.Dispose();

            //второе колесо
            SBr = new SolidBrush(Color.Transparent);
            p = new Pen(cl ? Color.Black : Color.White);
            Point O = new Point();
            O.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t));
            O.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t));
            Rect.Location = new Point(O.X - r, O.Y - r);
            Rect.Size = new Size(2 * r, 2 * r);
            Rect.Location = new Point(O.X - r, O.Y - r);
            Rect.Size = new Size(2 * r, 2 * r);
            g.FillEllipse(SBr, Rect);
            g.DrawEllipse(p, Rect);

            //его линии
            double f = omega * (r - R) * t / r;
            p.DashStyle = DashStyle.DashDot;
            Point t1 = new Point(Convert.ToInt32(O.X - r * Math.Sin(f)), Convert.ToInt32(O.Y - r * Math.Cos(f)));
            Point t2 = new Point(Convert.ToInt32(O.X + r * Math.Sin(f)), Convert.ToInt32(O.Y + r * Math.Cos(f)));
            t1.X = Convert.ToInt32(O.X - r * Math.Sin(f));
            t1.Y = Convert.ToInt32(O.Y - r * Math.Cos(f));
            t2.X = Convert.ToInt32(O.X + r * Math.Sin(f));
            t2.Y = Convert.ToInt32(O.Y + r * Math.Cos(f));
            g.DrawLine(p, t1, t2);
            t1.X = Convert.ToInt32(O.X - r * Math.Cos(f));
            t1.Y = Convert.ToInt32(O.Y + r * Math.Sin(f));
            t2.X = Convert.ToInt32(O.X + r * Math.Cos(f));
            t2.Y = Convert.ToInt32(O.Y - r * Math.Sin(f));
            g.DrawLine(p, t1, t2);

            //крифошип
            p.DashStyle = DashStyle.Solid;
            p.Width = 2;
            t1.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t));
            t1.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t));
            g.DrawLine(p, Center, t1);
            p.Dispose();
            SBr.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (fl)
                Picture(true, e.Graphics);
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int l = R - r;

            //новый рисунок нельзя пока движение не будет остановлено
            нарисоватьToolStripMenuItem.Enabled = false;
            //задавать новые геометрические и кинематические параметры нельзя
            // пока движение не остановлено
            геометрическиеToolStripMenuItem.Enabled = false;
            кинематическиеToolStripMenuItem.Enabled = false;
            //не зачем еще раз запускать
            начатьToolStripMenuItem.Enabled = false;
            //можно останавливать
            стопToolStripMenuItem.Enabled = true;
            //стерать нельзя пока движение не будет остановлено
            стеретьToolStripMenuItem.Enabled = false;
            Ochis();
            fl = true;
            Picture(true, g);
            timer1.Enabled = true;
            double f = omega * (R - r) * t / r;
            Point A = new Point();
            A.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t) + r * Math.Cos(f));
            A.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t) - r * Math.Sin(f));
            Point B = new Point();
            B.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t) + r * Math.Sin(f));
            B.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t) + r * Math.Cos(f));

            myListA.Clear();
            myListA.Add(A);
            myListB.Clear();
            myListB.Add(B);
        }

        private void Traek()
        {
            int l = R - r;

            double f = omega * (r - R) * t / r;
            Point A = new Point();
            A.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t) + r * Math.Cos(f));
            A.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t) - r * Math.Sin(f));
            Point B = new Point();
            B.X = Convert.ToInt32(Center.X + l * Math.Cos(omega * t) + r * Math.Sin(f));
            B.Y = Convert.ToInt32(Center.Y - l * Math.Sin(omega * t) + r * Math.Cos(f));

            myListA.Add(A);
            myListB.Add(B);

            Pen p = null;
            if (точкаАToolStripMenuItem.Checked)
            {
                p = new Pen(Color.Red);
                Point[] myMas = myListA.ToArray();
                g.DrawCurve(p, myMas);
            }
            if (точкаВToolStripMenuItem.Checked)
            {
                p = new Pen(Color.Blue);
                Point[] myMas = myListB.ToArray();
                g.DrawCurve(p, myMas);
            }
        }

        private void Ochis()
        {
            SolidBrush SBr = new SolidBrush(Color.White);
            g.FillRectangle(SBr, 0, 0, pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height);
            SBr.Dispose();
            fl = false;
        }

        private void стеретьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ochis();
            //можно рисовать
            нарисоватьToolStripMenuItem.Enabled = true;
            //нельзя стирать
            стеретьToolStripMenuItem.Enabled = false;
            //нечего запускать
            начатьToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Picture(false, g);
            t = t + 0.1;
            Picture(true, g);
            Traek();
        }

        private void точкаАToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void точкаВToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void геометрическиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MyF2 = new Form2();
            Pos = new Point(this.Location.X, this.Location.Y + this.Height - panel1.Height);
            MyF2.StartPosition = FormStartPosition.Manual;
            MyF2.Location = new Point(Pos.X, Pos.Y);

            if (MyF2.ShowDialog() == DialogResult.OK)
            {
                Lr1.Text = Convert.ToString(R) + " см";
                Lr2.Text = Convert.ToString(r) + " см";
            }
            стеретьToolStripMenuItem_Click_1(sender, e);
            нарисоватьToolStripMenuItem_Click(sender, e);
        }

        private void кинематическиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 MyF3 = new Form3();
            Pos = new Point(this.Location.X, this.Location.Y + this.Height - panel1.Height);
            MyF3.StartPosition = FormStartPosition.Manual;
            MyF3.Location = new Point(Pos.X, Pos.Y);
            if (MyF3.ShowDialog() == DialogResult.OK)
            {
                if (omega == 0)
                    MessageBox.Show("Вы задали угловую скорость равной 0");
                else
                    timer1.Interval = Convert.ToInt32(100 / Math.Abs(omega));
            }
            LOmega.Text = Convert.ToString(omega) + " рад/с";
            стеретьToolStripMenuItem_Click_1(sender, e);
            нарисоватьToolStripMenuItem_Click(sender, e);
        }

        private void стопToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // стереть можно
            стеретьToolStripMenuItem.Enabled = true;
            //новые параметры задавать можно
            геометрическиеToolStripMenuItem.Enabled = true;
            кинематическиеToolStripMenuItem.Enabled = true;
            //нечего останавливать
            стопToolStripMenuItem.Enabled = false;
            //можно запускать
            начатьToolStripMenuItem.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
