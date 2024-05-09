using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Grafika3
{
    public partial class Form1 : Form
    {
        //Připravte si grafické rozhraní s panelem o rozměrech 200 x 200, rámečkem a pictureboxem s vloženým obrázkem.
        //Upravte barvu pozadí na bílou a velikost boxu podle proporcí obrázku.
        //Chceme, aby se panáček pohyboval podle tlačítek a to vždy pouze jedním směrem.
        //Pohyb bude ukončen „nárazem do stěny“ nebo stiskem jiného tlačítka.
        //Optimalizujte rychlost pohybu (zpomalte) pomocí prvku Timer s intervalem cca 10.

        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        int index = 0;
        private void buttonRight_Click(object sender, EventArgs e)
        {
            index = 1;
            timer1.Start();
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            index = 2;
            timer1.Start();
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            index = 3;
            timer1.Start();
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            index = 4;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if(pictureBox1.Right < 200) //jede dokud pravej okraj pictureBox1 není na 200 - což je souřadnice pravý strany Panelu
                {
                    x += 5;
                    pictureBox1.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            else if (index == 2)
            {

                if (pictureBox1.Left > 0) //jede dokud levej okraj pictureBox1 není na 0 - což je souřadnice levý strany Panelu
                {
                    x -= 5;
                    pictureBox1.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            else if (index == 3)
            {

                if (pictureBox1.Top > 0) //jede dokud horní okraj pictureBox1 není na 0 - což je souřadnice horní strany Panelu
                {
                    y -= 5;
                    pictureBox1.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            else if (index == 4)
            {

                if (pictureBox1.Bottom < 200) //jede dokud dolní okraj pictureBox1 není na 200 - což je souřadnice dolní strany Panelu
                {
                    y += 5;
                    pictureBox1.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    timer1.Stop();
                }
                
            }
        }
    }
}
