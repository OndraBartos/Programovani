using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Uživatelské_rozhraní
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 75;
        int y = 25;
        int velikost = 300;
        int shapeIndex = 0;
        bool fill;
        Graphics g;
        Color myColor;
        Brush myBrush = new SolidBrush(Color.Black);
        Pen myPen = new Pen(Color.Black, 2);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if(shapeIndex == 1)
            {
                if(fill == true)
                {
                    g.FillRectangle(myBrush, x, y, velikost, velikost);
                }
                g.DrawRectangle(myPen, x, y, velikost, velikost);
            }
            else
            {
                if (fill == true)
                {
                    g.FillEllipse(myBrush, x, y, velikost, velikost);
                }
                g.DrawEllipse(myPen, x, y, velikost, velikost);               
            }

        }
        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            shapeIndex = 1;
        }
        private void radioButtonElipse_CheckedChanged(object sender, EventArgs e)
        {
            shapeIndex = 2;
        }
        private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFill.Checked)
            {
                fill = true;
            }
            else
            {
                fill = false;
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void červenáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.Red);
            myPen = new Pen(Color.Red, 2);
        }
        private void modráToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.Blue);
            myPen = new Pen(Color.Blue, 2);
        }
        private void zelenáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.Green);
            myPen = new Pen(Color.Green, 2);
        }
        private void žlutáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.Yellow);
            myPen = new Pen(Color.Yellow, 2);
        }        
    }
}
