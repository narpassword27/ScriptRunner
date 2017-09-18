using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptrunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Cyan, 1);

            int[] octoSizes = { 300, 230, 170, 120, 80, 50, 30 };

            var octoPoints = octoSizes.Select(GetOctogon);

            var lines = Enumerable.Range(0,8).Select(i => octoPoints.Select(arr => arr[i]).ToArray());



            foreach (var octogon in octoPoints)
            {
                l.DrawPolygon(p, octogon);
            }

            foreach (var line in lines)
            {
                l.DrawLines(p, line);
            }

            l.Dispose();
        }

        private Point[] GetOctogon(int radius)
        {
            List<Point> points = new List<Point>();
            float step = 45.0f;

            float angle = 22.5f;
            for (double i = 22.5; i < 22.5 + 360.0; i += step)
            {
                points.Add(DegreesToXY(angle, radius, new Point(290,280)));
                angle += step;
            }

            return points.ToArray();
        }

        private Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }
    }
}
