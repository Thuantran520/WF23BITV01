using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeHinhDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool isDrawing = false;
        Point startPoint;

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                var g = this.CreateGraphics();
                g.DrawLine(Pens.Red, startPoint, e.Location);

            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isDrawing = true;
        }
    }
}
