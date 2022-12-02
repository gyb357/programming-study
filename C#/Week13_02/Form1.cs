﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(50, 50, 75, 75);

            Rectangle[] rects = new Rectangle[] {
                new Rectangle(200, 100, 200, 100),
                new Rectangle(100, 80, 100, 100),
                new Rectangle(150, 100, 80, 50)
            };

            g.FillRectangle(Brushes.Lime, r);
            g.DrawRectangle(new Pen(Color.Black), r);

            g.FillRectangles(Brushes.Yellow, rects);
            g.DrawRectangles(new Pen(Color.Black), rects);
        }
    }
}
