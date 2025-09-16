using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Pen blackPen;
        public Form1()
        {
            InitializeComponent();
            blackPen = new Pen(Color.Black, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawAxis(e);
        }

        private void DrawAxis(PaintEventArgs e)
        {
            Point axisX_1 = new Point(0, 0);
            Point axisX_2 = new Point(this.Width, this.Height);
            e.Graphics.DrawLine(blackPen, axisX_1, axisX_2);

            Point axisY_1 = new Point(this.Width / 2,  0);
            Point axisY_2 = new Point(this.Width / 2, this.Height);
            e.Graphics.DrawLine(blackPen, axisY_1, axisY_2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
