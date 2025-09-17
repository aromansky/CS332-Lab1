using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        int height;
        int width;

        Pen blackPen;
        Font font;
        Brush brush;
        Func<double, double> fun;
        float xMax, xMin;
        float step;
        int cntTicks, tickLength;
        public Form1()
        {
            InitializeComponent();

            height = this.ClientSize.Height;
            width = this.ClientSize.Width;

            blackPen = new Pen(Color.Black, 1);
            font = new Font("Arial", 8);
            brush = Brushes.Black;

            fun = x => Math.Sin(x);
            xMax = (float)Math.PI;
            xMin = (float)-Math.PI;
            step = 0.002f;
            cntTicks = 4;
            tickLength = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPlot(e, fun, xMin, xMax, step, cntTicks, tickLength);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            height = this.ClientSize.Height;
            width = this.ClientSize.Width;
            Refresh();
        }

        private void DrawPlot(PaintEventArgs e, Func<double, double> fun,
            float xMin, float xMax, float step, int cntTicks, int tickLength)
        {
            (double, double) extremes = FunExtremes(fun, xMin, xMax, step);

            DrawAxis(e, blackPen);
            DrawAxisLabels(e, font, brush, blackPen);
            DrawAxisTicks(e, blackPen, xMin, xMax, cntTicks, tickLength);
            DrawAxisValues(e, font, brush, xMin, xMax, extremes, cntTicks);
            
            DrawFun(e, fun, xMin, xMax, step, extremes);
        }

        private void DrawAxis(PaintEventArgs e, Pen pen)
        {
            Point axisX_1 = new Point(0, height / 2);
            Point axisX_2 = new Point(width, height / 2);

            e.Graphics.DrawLine(pen, axisX_1, axisX_2);

            Point axisY_1 = new Point(width / 2, 0);
            Point axisY_2 = new Point(width / 2, height);
            e.Graphics.DrawLine(pen, axisY_1, axisY_2);
        }

        private void DrawAxisLabels(PaintEventArgs e, Font font, Brush brush, Pen pen)
        {
            e.Graphics.DrawString("X", font, brush, width - 20, height / 2 - 20);
            e.Graphics.DrawString("Y", font, brush, width / 2 - 15, 5);
        }

        private void DrawAxisTicks(PaintEventArgs e, Pen pen, float xMin, float xMax, int cntTicks, int tickLength)
        {
            if (cntTicks == 0)
            {
                return;
            }

            int xCenter = width / 2;
            int yCenter = height / 2;

            int stepX = width / (2 * cntTicks);
            int stepY = height / (2 * cntTicks);
            for (int i = 1; i <= cntTicks; i++)
            {
                DrawTickX(e, pen, xCenter - stepX * i, yCenter, tickLength);
                DrawTickX(e, pen, xCenter + stepX * i, yCenter, tickLength);

                DrawTickY(e, pen, xCenter, yCenter - stepY * i, tickLength);
                DrawTickY(e, pen, xCenter, yCenter + stepY * i, tickLength);
            }
        }

        private void DrawTickX(PaintEventArgs e, Pen pen, int x, int y, int length)
        {
            Point tickStart = new Point(x, y - length / 2);
            Point tickEnd = new Point(x, y + length / 2);
            e.Graphics.DrawLine(pen, tickStart, tickEnd);
        }

        private void DrawAxisValues(PaintEventArgs e, Font font, Brush brush, float xMin, float xMax, (double min, double max) extremes, int cntTicks)
        {
            int xCenter = width / 2;
            int yCenter = height / 2;
            int labelOffset = 5;

            int stepX = width / (2 * cntTicks);
            int stepY = height / (2 * cntTicks);

            var (yMin, yMax) = extremes;
            double mathStepX = (xMax - xMin) / (2 * cntTicks);
            double mathStepY = (yMax - yMin) / (2 * cntTicks);

            for (int i = 1; i <= cntTicks; i++)
            {
                e.Graphics.DrawString($"{-i * mathStepX:F2}", font, brush, xCenter - stepX * i, yCenter + labelOffset);
                e.Graphics.DrawString($"{i * mathStepX:F2}", font, brush, xCenter + stepX * i, yCenter + labelOffset);

                e.Graphics.DrawString($"{i * mathStepY:F2}", font, brush, xCenter + labelOffset, yCenter - stepY * i);
                e.Graphics.DrawString($"{-i * mathStepY:F2}", font, brush, xCenter + labelOffset, yCenter + stepY * i);
            }
        }

        private void DrawTickY(PaintEventArgs e, Pen pen, int x, int y, int length)
        {
            Point tickStart = new Point(x - length / 2, y);
            Point tickEnd = new Point(x + length / 2, y);
            e.Graphics.DrawLine(pen, tickStart, tickEnd);
        }

        private void DrawFun(PaintEventArgs e, Func<double, double> fun,
            float xMin, float xMax, float step, (double min, double max) extremes)
        {
            var (yMin, yMax) = extremes;
            List<PointF> points = new List<PointF>();

            for (double mathX = xMin; mathX <= xMax; mathX += step)
            {
                double mathY = fun(mathX);

                float x = width / 2 + (float)(mathX / (xMax - xMin) * width);
                float y = height / 2 - (float)(mathY / (yMax - yMin) * height);

                points.Add(new PointF(x, y));
            }

            using (Pen dotPen = new Pen(Color.Red, (float)0.5))
            {
                e.Graphics.DrawLines(dotPen, points.ToArray());
            }
        }

        private (double min, double max) FunExtremes(Func<double, double> fun, double xMin, double xMax, double step)
        {
            double yMin = double.MaxValue;
            double yMax = double.MinValue;

            for (double x = xMin; x <= xMax; x += step)
            {
                double y = fun(x);
                yMin = Math.Min(yMin, y);
                yMax = Math.Max(yMax, y);
            }

            return (yMin, yMax);
        }

        private void UpdateFun(Func<double, double> fun)
        {
            this.fun = fun;
            Refresh();
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFun(x => Math.Sin(x));
            
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFun(x => Math.Cos(x));
        }


        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFun(x => Math.Pow(x, 2));
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            
            ((ToolStripTextBox)sender).SelectAll();
        }

        private void toolStripTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && 
                float.TryParse(((ToolStripTextBox)sender).Text, out float buf) &&
                buf >= 0)
            {
                xMax = buf;
                Refresh();
            }
        }

        private void toolStripTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                float.TryParse(((ToolStripTextBox)sender).Text, out float buf) &&
                buf != 0)
            {
                xMin = -Math.Abs(buf);
                xMax = Math.Abs(buf);
                Refresh();
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                int.TryParse(((ToolStripTextBox)sender).Text, out int buf) &&
                buf > 0)
            {
                cntTicks = buf;
                Refresh();
            }
        }

        private void toolStripTextBox4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                int.TryParse(((ToolStripTextBox)sender).Text, out int buf) &&
                buf > 0)
            {
                tickLength = buf;
                Refresh();
            }
        }

        private void toolStripTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if(
                double.TryParse(((ToolStripTextBox)sender).Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double buf) &&
                buf > 0)
            {
                step = (float)buf;
                Refresh();
            }
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFun(x => Math.Pow(x, 3));
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFun(x => x);
        }
    }
}
