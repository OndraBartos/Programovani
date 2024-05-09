using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Grafika1
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        //Nakreslete "trojúhelník" koleček 10x10 o průměru kolečka 20 pixlů.
        //Možné jsou 4 různé varianty podle umístění rohu s pravým úhlem.
        //Obrazec se vykreslí při startu programu.
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int prumer = 20;
            int pocet = 10;
            int x = 50;
            int y = 50;
            Brush myBrush = new SolidBrush(Color.White);

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < pocet; i++) //udělá jeden sloupec
                {
                    g.FillEllipse(myBrush, x, y, prumer, prumer);
                    y += prumer;
                }
                x += prumer;
                pocet -= 1;
                y = 50 + (10 - pocet) * prumer;
            }
            //hotovo jednoduchý, zkusim ještě vylepšení

            int prumer2 = 20;
            int pocet2 = 1;
            int x2 = 75;
            int y2 = 25;
            Brush myBrush2 = new SolidBrush(Color.Red);
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < pocet2; i++) //udělá jeden sloupec
                {
                    g.FillEllipse(myBrush2, x2, y2, prumer2, prumer2);
                    y2 += prumer2;
                }
                x2 += prumer2;
                pocet2 += 1;
                y2 = 25;
            }
            //krása střídá nádheru, mam to a celý sám

        }
    }
}
