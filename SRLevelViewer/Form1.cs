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
            //l.DrawLine(p, 50, 50, 200, 200);
            l.DrawEllipse(p, 250, 250, 100, 100);
            l.DrawEllipse(p, 225, 225, 150, 150);
            l.DrawEllipse(p, 200, 200, 200, 200);
            l.DrawEllipse(p, 175, 175, 250, 250);
            l.DrawEllipse(p, 150, 150, 300, 300);
            l.DrawEllipse(p, 125, 125, 350, 350);
            l.DrawEllipse(p, 100, 100, 400, 400);
            

            l.Dispose();
        }
    }
}
