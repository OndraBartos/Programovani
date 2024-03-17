using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalovaniUkol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen myPen = new Pen(Color.Black, 1);
        Pen Eraser = new Pen(Color.White, 25); //guma má bílou barvu a danou velikost 25px
        int index; //index na volbu kreslení - pero, guma, kruh, čtverec
        int x, y, fX, fY, sX, sY; //pro kreslení objektů
        //x - aktuální poloha myši na souřadnici x
        //y - aktuální poloha myši na souřadnici y
        //sX, sY - počáteční body kreslení, odkud zmáčknu myš - startX, startY
        //fX - finální šírka objektu - final souřadnice x
        //fY - finální výška objektu - final souřadnice y



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true; //pokud držím stisknoutou myš tak true
            py = e.Location;

            sX = e.Location.X;  //na kreslení objektů
            sY = e.Location.Y;  //když zmáčknu myš, tak ty body uloží jako počáteční body kreslení
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //sleduje pohyb myši
        {
            if (paint == true) //pokud je paint true - (mám zmáčklou myš), tak povolí akci -> kreslení, gumování...
            {
                if (index == 1)
                {
                    px = e.Location; //aktuální pozice myši uložená do px
                    g.DrawLine(myPen, px, py); //nakreslí čáru mezi px a py
                    py = px; //nastaví novou hodnotu py na aktální polohu myši aby se dalo kreslit dál
                }
                else if (index == 2)
                {
                    px = e.Location; //to samé jako u pera, akorát použiju pero, -->
                    g.DrawLine(Eraser, px, py); // --> co má barvu nastavenou na bílou a tím to přemaluju
                    py = px;
                }
            }
            pictureBox1.Refresh(); //znovu vykreslí paintbox a rím je vidět co malujeme

            x = e.Location.X; //aktuální poloha myši na souřadnici x
            y = e.Location.Y; //aktuální poloha myši na souřadnici y
            fX = e.Location.X - sX; //finální šírka objektu - final souřadnice x
            fY = e.Location.Y - sY; //finální výška objektu - final souřadnice y
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false; //jakmile pustim myš a už jí nedržim stisklou tak false


            fX = x - sX; //vypočítání finálních souřadnic -> aktuální souřadnice mínus původní souřadnice
            fY = y - sY;

            if (index == 3)
            {
                g.DrawEllipse(myPen, sX, sY, fX, fY); //kruh
            }               
            else if (index == 4)                            //čtverec a kruh stejným způsobem
            {
                g.DrawRectangle(myPen, sX, sY, fX, fY); //čtverec
            }
        }
        private void newPageButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }
        private void buttonPen_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e) //dělá mi nákres pri kerslení objektů
        {
            Graphics g = e.Graphics;
            if (paint == true)
            {
                if (index == 3)
                {
                    g.DrawEllipse(myPen, sX, sY, fX, fY); //kruh
                }
                else if (index == 4)                            //čtverec a kruh stejným způsobem
                {
                    g.DrawRectangle(myPen, sX, sY, fX, fY); //čtverec
                }
            }
        }


    }
}
