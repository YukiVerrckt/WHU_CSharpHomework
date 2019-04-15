using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7_2
{
    public partial class Form1 : Form
    {
        private Graphics grap;
        double th1;
        double th2 ;
        double per1;
        double per2;
        int k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            th1 = trackBar1.Value * Math.PI / 180;
            th2 = trackBar2.Value * Math.PI / 180;
            per1 = trackBar3.Value / 10.0;
            per2 = trackBar4.Value / 10.0;
            k = trackBar5.Value;
            if (grap == null)
                grap = this.CreateGraphics();
            else
            {
                grap.Clear(this.BackColor);
            }
            drawCayleyTree(10, this.Size.Width/2, this.Size.Height, 100, -Math.PI / 2);
        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2, y2;
            x2 = x0 + leng * k * Math.Cos(th);
            y2 = y0 + leng * k * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            grap.DrawLine(Pens.Blue,(int)x0,(int)y0,(int)x1,(int)y1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

    }
}
