using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._5.Pole_ve_formulářích2
{
    public partial class Form1 : Form
    {
        //Vytvořte 10 prvkové pole a naplňte ho náhodnými čísly z intervalu <0,100>
        //Vygenerovaná čísla současně kontrolně vypište do textového pole, oddělujte mezerami.
        //Zjistěte průměr čísel a kolik z nich je větší než průměr.
        //Pro následné zpracování pole použijte(kde je to možné) cyklus foreach.
        //Program bude řídit událost Load okna(formuláře).

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] myArray = new int[10];
            int celkem = 0;
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < myArray.Length; i++) //naplnění pole
            {
                myArray[i] = rnd.Next(0, 101); //náhodná čísla od 0 do 100
                //celkem += myArray[i]; //zároveň si je ukládám abych pak mohl udělat průměr
                string text = myArray[i].ToString(); //rovnou taky vypisuju do textBoxu
                textBoxPole.Text += text + " ";
            }
            //celkem = myArray.Sum(); //místo toho abych to musel sčítat v tom for cyklu
            foreach (int prvek in myArray) //takhle můžu udělat foreach na celkem
            {
                celkem += prvek;
            }
            //double result1 = (double)celkem / (double)myArray.Length; 
            //tentokrát mi fungujou oba průměry -> asi musí být všechno v double
            double result = myArray.Average();
            //string vysledek = celkem.ToString(); z nějakýho mně záhadnýho důvodu nemusím teď přeádět na string
            for (int i = 0; i < myArray.Length; i++)
            {
                if (result < myArray[i]) 
                {
                    count++;
                }
            }

            textBoxVysledek.Text += "Celkem: " + celkem  + " " + Environment.NewLine;                 
            textBoxVysledek.Text += "Průměr: " + result + " " + Environment.NewLine;
            textBoxVysledek.Text += "Větších než průměr: " + count;
            //!!! Environment.NewLine udělá enter v textBoxu a snad i jinde !!!

            //jakoby zvládl jsem všechno udělat for cyklem a nikde jsem nedělal foreach,
            //protože nevim jak se foreach dělá  :)

        }
    }
}
