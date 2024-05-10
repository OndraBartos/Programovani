using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace znovaOOP
{using System.Drawing; //pro jistotu to hodim i sem

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //musím to dát sem aby to měla i ty funkce
        Circle Kruh1 = new Circle();
        Potomek Kruh2 = new Potomek();
        Potomek Kruh3 = new Potomek();
        Potomek Cara = new Potomek();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Circle Kruh1 = new Circle();  tady mi to nestačí potom to ty funkce nevidí tím že je to private
            //Potomek Kruh2 = new Potomek();
            //Potomek Kruh3 = new Potomek();

            Kruh1.x = 20;
            Kruh1.y = 20;
            Kruh1.size = 100;
            Kruh1.myPen = new Pen(Color.Aqua, 1);
            //Kruh1.myBrush = new SolidBrush(Color.Aqua);

            Kruh2.x = 20;
            Kruh2.y = 220;
            Kruh2.size = 30;
            Kruh2.myPen = new Pen(Color.Red, 1);
            //Kruh2.myBrush = new SolidBrush(Color.Red);

            Kruh3.x = 220;
            Kruh3.y = 20;
            Kruh3.size = 30;
            Kruh3.myPen = new Pen(Color.Red, 1);
            //Kruh3.myBrush = new SolidBrush(Color.Red);

            Cara.x = 220;
            Cara.y = 220;
            Cara.x2 = 300;
            Cara.y2 = 300;
            Cara.myPen = new Pen(Color.Red, 1);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Kruh1.myPen, Kruh1.x, Kruh1.y, Kruh1.size, Kruh1.size);
            g.DrawEllipse(Kruh2.myPen, Kruh2.x, Kruh2.y, Kruh2.size, Kruh2.size);
            g.DrawEllipse(Kruh3.myPen, Kruh3.x, Kruh3.y, Kruh3.size, Kruh3.size);
            g.DrawLine(Cara.myPen, Cara.x, Cara.y, Cara.x2, Cara.y2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.M) //M jako menší
            {
                Kruh1.zmensit();
                Kruh2.zmensit();
                Kruh3.zmensit();
            }
            if (e.KeyCode == Keys.V) //V jako větší
            {
                Kruh1.zvetsit();
                Kruh2.zvetsit();
                Kruh3.zvetsit();
            }
            if (e.KeyCode == Keys.Left) //Left je pro šipku doleva
            {
                Kruh2.doLeva();
                Kruh3.doLeva();
                Cara.doLeva();
            }
            if (e.KeyCode == Keys.Right) //Right je pro šipku doprava
            {
                Kruh2.doPrava();
                Kruh3.doPrava();
                Cara.doPrava();
            }
            

            Refresh(); //!!! musí být vždy na konci jinak mi to nebude fungovat !!!
        }
    }
}
