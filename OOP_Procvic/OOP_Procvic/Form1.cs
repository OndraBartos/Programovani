using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Procvic
{
    public partial class Form1 : Form
    {
        //instance si pojmenovat krátce, protože názvy se budou hodně opakovat
        Kruh Kruh1 = new Kruh();
        Potomek Kruh2 = new Potomek();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sem si napíšu to co budu používat
            Kruh1.myPen = Pens.Red;
            Kruh2.myPen = Pens.Blue;
            Kruh1.velikost = 100;
            Kruh1.x = Kruh1.y = 0;
            Kruh2.velikost = 50;
            Kruh2.x = Kruh2.y = 200;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Kruh1.myPen, Kruh1.x, Kruh1.y, Kruh1.velikost, Kruh1.velikost);
            g.DrawEllipse(Kruh2.myPen, Kruh2.x, Kruh2.y, Kruh2.velikost, Kruh2.velikost);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyCode = Kyes.to co chci!!!!
            if (e.KeyCode == Keys.M)
            {
                Kruh1.Zmensit();
                Kruh2.Zmensit();
            }
            if (e.KeyCode == Keys.Z)
            {
                Kruh1.Zvetsit();
                Kruh2.Zvetsit();
            }
            if (e.KeyCode == Keys.Right)
            {
                Kruh2.doPrava();
            }
            if (e.KeyCode == Keys.Left)
            {
                Kruh2.doLeva();
            }

            Refresh(); //musí být vždy na konci jinak mi to nebude fungovat, další jsou třeba invalidate
        }

        
    }
}
