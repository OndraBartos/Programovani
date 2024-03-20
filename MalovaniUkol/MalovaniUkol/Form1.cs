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

            this.Width = 995; //daná šířka a výška formuláře aby se do něj hezky vešlo plátno i panel
            this.Height = 660;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py; //souřadnice myši pro sledování jejího pohybu v pictureBox1_MouseMove
        //Color myColor = Color.Black;
        Pen myPen = new Pen(Color.Black, 1);
        Brush myBrush = new SolidBrush(Color.Black);
        Pen Eraser = new Pen(Color.White, 30); //guma má bílou barvu a danou velikost 30px
        Brush eraserBrush = new SolidBrush(Color.White);
        int index; //index na volbu kreslení - pero, guma, kruh, čtverec
        int x, y, fX, fY, sX, sY; //pro kreslení objektů
        //x - aktuální poloha myši na souřadnici x
        //y - aktuální poloha myši na souřadnici y
        //sX, sY - počáteční body kreslení, odkud zmáčknu myš - startX, startY
        //fX - finální šírka objektu - final souřadnice x
        //fY - finální výška objektu - final souřadnice y

        //funkce na změnu barvy pera
        private void ChangePenColor(Color newColor)
        {
            myPen.Color = newColor; //změníme barvu pera na novou barvu, kterou přijmeme jako parametr funkce
        }
        //funkce na změnu tloušťky pera
        private void ChangePenSize(float myWidth)
        {
            myPen.Width = myWidth; //změníme tloušťky pera na novou tloušťky, kterou přijmeme jako parametr funkce
        }

        private void ChangeBrushColor(Color newColor)
        {
            myBrush = new SolidBrush(newColor); //u štetce nejde měnit barva jako u pera, musím vytvořit nový štetec
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true; //pokud držím stisknoutou myš tak true
            py = e.Location;

            sX = e.Location.X;  //na kreslení objektů
            sY = e.Location.Y;  //když zmáčknu myš, tak ty souřadnice uloží jako počáteční bod kreslení
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //sleduje pohyb myši
        {
            if (paint == true) //pokud je paint true - (mám zmáčklou myš), tak povolí akci -> kreslení, gumování...
            {
                if (index == 1)
                {
                    px = e.Location; //aktuální pozice myši uložená do px                   
                    g.DrawLine(myPen, px, py); //nakreslí čáru mezi px a py
                    float r = myPen.Width; //r - průměr kružnice (šířka, výška)
                    float Cx = px.X - r / 2; //souřadnice pro generování kruhů
                    float Cy = px.Y - r / 2; //Cx/Cy - circle x/circle y
                    g.FillEllipse(myBrush, Cx, Cy, r, r); //kruh na vyplnění mezer
                    py = px; //nastaví novou hodnotu py na aktální polohu myši aby se dalo kreslit dál
                }
                else if (index == 2)
                {
                    px = e.Location; //to samé jako u pera, akorát použiju pero, -->
                    g.DrawLine(Eraser, px, py); // --> co má barvu nastavenou na bílou a tím to přemaluju
                    float r = 30;
                    float Cx = px.X - r / 2;
                    float Cy = px.Y - r / 2;
                    g.FillEllipse(eraserBrush, Cx, Cy, r, r); 
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
            paint = false; //jakmile pustim myš a už jí nedržim stisklou tak -> false


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
            else if (index == 5)
            {
                g.DrawLine(myPen, sX, sY, x, y);
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
        private void buttonLine_Click(object sender, EventArgs e)
        {
            index = 5;
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
                else if (index == 5)
                {
                    g.DrawLine(myPen, sX, sY, x, y);
                }
            }
        }
        //Nastavování barev
        private void colorBlack_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Black);
            ChangeBrushColor(Color.Black);
        }
        private void colorWhite_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.White);
            ChangeBrushColor(Color.White);
        }
        private void colorCyan_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Cyan);
            ChangeBrushColor(Color.Cyan);
        }
        private void colorGreen_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Green);
            ChangeBrushColor (Color.Green);
        }
        private void colorBlue_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Blue);
            ChangeBrushColor(Color.Blue);
        }
        private void colorYellow_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Yellow);
            ChangeBrushColor (Color.Yellow);
        }
        private void colorPurple_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Purple);
            ChangeBrushColor(Color.Purple);
        }
        private void colorOrange_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Orange);
            ChangeBrushColor(Color.Orange);
        }
        private void colorPink_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Pink);
            ChangeBrushColor(Color.Pink);
        }
        private void colorRed_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Red);
            ChangeBrushColor(Color.Red);
        }

        //Nastavení tlouišťky čáry
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ChangePenSize(hScrollBar1.Value);
        }


    }
}
