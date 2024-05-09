using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Grafika2
{
    using System.Drawing;
    public partial class Form1 : Form
    {
        //a, Nakreslete pod sebou 10 čar o náhodných délkách, maximálně 200 px.
        //Vzdálenost čar 20 px.Zvolte vhodně velikost prvku Panel, který bude mít viditelný rámeček.
        //b, Nakreslete na náhodných pozicích kolečka o průměru 10 pixlů.Počet koleček zadá uživatel.

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e) //jenom vygeneruje nový
        {
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 2);
            Random rnd = new Random();
            int xS = 0;
            int xF = 0;
            int yS = 30;
            int yF = 30;
            for (int i = 0; i < 10; i++)
            {
                xF = rnd.Next(50, 300);
                g.DrawLine(myPen, xS, yS, xF, yF); //potřebuješ 4 souřadnice na dva body
                yS += 20;
                yF += 20;
            }
            //HOTOVO EASY
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Red);
            Random rnd = new Random();
            int x = 0;
            int y = 0;
            int r = 10;
            int pocet = Convert.ToInt32(numericUpDownPocet.Value);
            for (int i = 0; i < pocet; i++)
            {
                x = rnd.Next(20, 330);
                y = rnd.Next(20, 230);
                g.FillEllipse(myBrush, x, y, r, r);
            }
            //HOTOVO EASY
        }
    }
}
