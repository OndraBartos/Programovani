using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceniNaForms
{
    internal class Rectangle
    {
        public int x, y, width, height;
        public bool filled;
        public Brush myBrush;
        public Pen myPen;

        public Rectangle(int x , int y, int width, int height, bool filled, Brush myBrush, Pen myPen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.filled = filled;
            this.myBrush = myBrush;
            this.myPen = myPen;
        }
        public void PaintRectangle(Graphics g)
        {
            if (filled)
            {
                g.FillRectangle(myBrush, x, y, width, height);
            }
            else
            {
                g.DrawRectangle(myPen, x, y, width, height);
            }
        }
    }
}
