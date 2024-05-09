using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3._3.Kódování_znaků
{
    public partial class Form1 : Form
    {
        //a, Vypište všechna velká písmena abecedy – výstup do MessageBoxu
        //b, Vypisujte náhodně velká písmena abecedy – výstup do TextBoxu
        //Při řešení využijte ASCII tabulku.

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonWriteAll_Click(object sender, EventArgs e)
        {
            string vysledek = "";
            //A je 65 Z je 90 ->
            for (int i = 65; i <= 90; i++)
            {
                char pismeno = (char)i; //tenhle řádek je důležitej
                //i jsou čísla a on má uloženou ASCII tabulku ze které ví jaký znak odpovídá jakému číslu
                //velká písmena jak píšu nahoře jsou v rozmezí <65;90>
                //v každém tom forcyklu převede to šíslo na písmeno ale pořád to vídí jako jenom char = znak
                //proto je ještě potřeba to převést na string a ten pak přidávám k výsledku který mi pak ukáže MessageBox
                vysledek += pismeno.ToString() + " ";
            }
            MessageBox.Show(vysledek);
        }
        private void buttonWriteRnd_Click(object sender, EventArgs e)
        {
            string vysledek = "";
            Random rnd = new Random();
            int pocet = rnd.Next(5, 200);
            for (int j = 1; j <= pocet; j++)
            {
                int znak = rnd.Next(65, 91);
                char pismeno = (char)znak;
                vysledek += pismeno.ToString() + " ";                
            }            
            textBox1.Text = vysledek;
        }
        /*
         * char pismeno = (char)i; !!! tenhle řádek je důležitej !!!
         * i jsou čísla a on má uloženou ASCII tabulku ze které ví jaký znak odpovídá jakému číslu
         * velká písmena jak píšu nahoře jsou v rozmezí <65;90>
         * v každém tom forcyklu převede to šíslo na písmeno ale pořád to vídí jako jenom char = znak
         * proto je ještě potřeba to převést na string a ten pak přidávám k výsledku který mi pak ukáže MessageBox
         * 
        */
    }
}
