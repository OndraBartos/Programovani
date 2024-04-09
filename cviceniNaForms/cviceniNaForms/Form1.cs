using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cviceniNaForms
{
    public partial class Form1 : Form
    {
        Rectangle RectangleInstance;
        bool isLeftMouseDown = false;
        bool isRightMouseDown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RectangleInstance = new Rectangle(100,100, 100, 100, false, Brushes.Gold, Pens.Gold);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (RectangleInstance.filled)
            {
                e.Graphics.FillRectangle(
                    RectangleInstance.myBrush,
                    RectangleInstance.x,
                    RectangleInstance.y,
                    RectangleInstance.width,
                    RectangleInstance.height);
            }
            else
            {
                e.Graphics.DrawRectangle(
                    RectangleInstance.myPen,
                    RectangleInstance.x,
                    RectangleInstance.y,
                    RectangleInstance.width,
                    RectangleInstance.height);
            }

            //PaintRectangle()
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                isRightMouseDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                isRightMouseDown = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftMouseDown)
            { 
                RectangleInstance.x = e.X;
                RectangleInstance.y = e.Y;
                Refresh();
            }
            else if (isRightMouseDown)
            {
                RectangleInstance.width = e.X - RectangleInstance.x;
                RectangleInstance.height = e.Y - RectangleInstance.y;
                Refresh();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'f')
            {
                RectangleInstance.filled = !RectangleInstance.filled;
                Refresh();
            }
        }
    }
}
