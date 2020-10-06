using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;

namespace Ожогина_c_sharp
{
   
    public partial class Form1 : Form
    {
        int ccc = 0;
        static int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            button2.BackColor = colorDialog2.Color;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1 as Bitmap;
            pictureBox6.Image = Properties.Resources._1 as Bitmap;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2 as Bitmap;
            pictureBox6.Image = Properties.Resources._2 as Bitmap;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._3 as Bitmap;
            pictureBox6.Image = Properties.Resources._3 as Bitmap;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Color clr1 = colorDialog1.Color;
            Color clr2 = colorDialog2.Color;
            draw(clr1, clr2);
        }

        private void draw1(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            peni.Width = 3;
            Pen pend = new Pen(Color.Blue);
            pend.Width = 5;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush blue = new SolidBrush (Color.Blue);




            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };
          
            g.DrawEllipse(pen, 120, 160, 170, 60);
            g.DrawLine(pend, 170, 180, 180, 120);
            g.DrawLine(pend, 190, 180, 180, 120);

            g.DrawLine(pend, 215, 180, 215, 120);
            g.DrawLine(pend, 235, 180, 215, 120);
            g.DrawEllipse(pen, 175, 110, 10, 10);
            g.DrawEllipse(pen, 210, 110, 10, 10);
            g.DrawLine(pend, 280, 180, 330, 120);
            g.DrawLine(pend, 130, 180, 70, 120);
            g.DrawLine(pend, 170, 220, 140, 260);
            g.DrawLine(pend, 230, 220, 260, 260);
            g.DrawLine(pen, 80, 80, 70, 120);
            g.DrawLine(pen, 40, 80, 70, 120);
            g.DrawLine(pen, 340, 80, 330, 120);
            g.DrawLine(pen, 300, 80, 330, 120);



            /* g.DrawLine(pend, 280, 170, 250, 100);
             g.DrawEllipse(pen, 245, 160, 70, 30);
             g.FillEllipse(blue, 245, 160, 70, 30);
             g.FillEllipse(colorblueti, 120, 160, 170, 50);
             g.DrawEllipse(pen, 120, 160, 170, 50);
             g.FillEllipse(colorblueti, 145, 135, 120, 50);
             g.DrawEllipse(pen, 145, 135, 120, 50);
             g.FillEllipse(colorblueti, 170, 120, 70, 30);     
             g.DrawEllipse(pen, 170, 120, 70, 30);
        */
            Point[] Pid ={
                new Point(230 , 115),
                new Point(300 , 160),
                new Point(150 , 180),
                new Point(170, 120),
                                 };

            pictureBox5.Image = bmp;
        }
        private void draw(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            peni.Width = 3;
            Pen pend = new Pen(Color.Blue);
            pend.Width = 5;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush colorred = new SolidBrush(Color.Red);
            SolidBrush blue = new SolidBrush(Color.Blue);
            Point[] Pid ={
                new Point(230 , 120),
                new Point(300 , 60),
                new Point(150 , 80),
                new Point(170, 125),
                                 };
   

            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };
            g.DrawEllipse(pen, 120, 160, 170, 60);
            g.DrawLine(pend, 170, 180, 180, 120);
            g.DrawLine(pend, 190, 180, 180, 120);

            g.DrawLine(pend, 215, 180, 215, 120);
            g.DrawLine(pend, 235, 180, 215, 120);
            g.DrawEllipse(pen, 175, 110, 10, 10);
            g.DrawEllipse(pen, 210, 110, 10, 10);
            g.FillEllipse(blue, 175, 110, 10, 10);
            g.FillEllipse(blue, 210, 110, 10, 10);
            g.DrawLine(pend, 280, 180, 330, 120);
            g.DrawLine(pend, 130, 180, 70, 120);
            g.DrawLine(pend, 170, 220, 140, 260);
            g.DrawLine(pend, 230, 220, 260, 260);
            g.DrawLine(pen, 80, 80, 70, 120);
            g.DrawLine(pen, 50, 80, 70, 120);
            g.DrawLine(pen, 330, 80, 330, 120);
            g.DrawLine(pen, 300, 80, 330, 120);
            pictureBox5.Image = bmp;
        }
        private void draw2(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            peni.Width = 3;
            Pen pend = new Pen(Color.Blue);
            pend.Width = 5;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush blue = new SolidBrush(Color.Blue);




            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };
            g.DrawEllipse(pen, 120, 160, 170, 60);
            g.DrawLine(pend, 170, 180, 180, 120);
            g.DrawLine(pend, 190, 180, 180, 120);

            g.DrawLine(pend, 215, 180, 215, 120);
            g.DrawLine(pend, 235, 180, 215, 120);
            g.DrawEllipse(pen, 175, 110, 10, 10);
            g.DrawEllipse(pen, 210, 110, 10, 10);
            g.DrawLine(pend, 280, 180, 330, 120);
            g.DrawLine(pend, 130, 180, 70, 120);
            g.DrawLine(pend, 170, 220, 140, 260);
            g.DrawLine(pend, 230, 220, 260, 260);
            g.DrawLine(pen, 80, 80, 70, 120);
            g.DrawLine(pen, 60, 80, 70, 120);
            g.DrawLine(pen, 320, 80, 330, 120);
            g.DrawLine(pen, 300, 80, 330, 120);

            Point[] Pid ={
                new Point(230 , 115),
                new Point(300 , 160),
                new Point(150 , 180),
                new Point(170, 120),
                                 };

            pictureBox5.Image = bmp;
        }
        private void draw3(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            peni.Width = 3;
            Pen pend = new Pen(Color.Blue);
            pend.Width = 5;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush blue = new SolidBrush(Color.Blue);




            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };
            g.DrawEllipse(pen, 120, 160, 170, 60);
            g.DrawLine(pend, 170, 180, 180, 120);
            g.DrawLine(pend, 190, 180, 180, 120);

            g.DrawLine(pend, 215, 180, 215, 120);
            g.DrawLine(pend, 235, 180, 215, 120);
            g.DrawEllipse(pen, 175, 110, 10, 10);
            g.DrawEllipse(pen, 210, 110, 10, 10);
            g.DrawLine(pend, 280, 180, 330, 120);
            g.DrawLine(pend, 130, 180, 70, 120);
            g.DrawLine(pend, 170, 220, 140, 260);
            g.DrawLine(pend, 230, 220, 260, 260);
            g.DrawLine(pen, 80, 80, 70, 120);
            g.DrawLine(pen, 75, 80, 70, 120);
            g.DrawLine(pen, 295, 80, 330, 120);
            g.DrawLine(pen, 300, 80, 330, 120);

            Point[] Pid ={
                new Point(230 , 115),
                new Point(300 , 160),
                new Point(150 , 180),
                new Point(170, 120),
                                 };

            pictureBox5.Image = bmp;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._7 as Bitmap;
            pictureBox6.Image = Properties.Resources._7 as Bitmap;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._5 as Bitmap;
            pictureBox6.Image = Properties.Resources._5 as Bitmap;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ccc == 0)
            {
                ccc = ccc + 1;
                draw1(colorDialog1.Color, colorDialog2.Color);

            }
            else if (ccc==1)
            {
                ccc = ccc + 1;
                draw(colorDialog1.Color, colorDialog2.Color);
                
            }
             else if (ccc==2){
                ccc = ccc + 1;
                draw2(colorDialog1.Color, colorDialog2.Color);
            }
              else if (ccc == 3)
            {
                ccc = ccc + 1;
                draw3(colorDialog1.Color, colorDialog2.Color);
                ccc = 0;
            }

            
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
    }
}
