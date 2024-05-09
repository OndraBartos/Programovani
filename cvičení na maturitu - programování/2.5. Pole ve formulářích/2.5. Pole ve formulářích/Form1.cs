using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._5.Pole_ve_formulářích
{
    public partial class Form1 : Form
    {
        //Vytvořte pole - maximálně 10 čísel.
        //Čísla zadávejte přes textbox, při vkládání oddělujte entrem.
        //Při načítání do pole čísla současně souhrnně ukládejte do jiného textboxu, čísla oddělujte mezerami.
        //Zjistěte nejmenší číslo v poli a kolikrát se v řadě vyskytuje. Výsledek vytiskněte do dalšího textového pole.
        int[] myArray = new int[10];
        int index = 0;
        int min;
        int pocetMin;
        public Form1()
        {
            InitializeComponent();
            textBoxPole.Text = ""; //nastavení toho že ze začátku jsou textboxy prázdné
            textBoxVstup.Text = "";
            textBoxVysledek.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBoxVstup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myArray[index] = Convert.ToInt32(textBoxVstup.Text);
                textBoxPole.Text += textBoxVstup.Text + " ";
                index++;
                textBoxVstup.Text = ""; //potom co se vše udělá, tak se text smaže a textBoxVstup je opět prázdný
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            min = myArray[0]; //nastavím první číslo v poli jako minimum
            for (int i = 1; i < index; i++) //projíždím pole
            {
                if (myArray[i] < min) //a pokud je nějaké číslo menší než mé minimum tak je přepíšu
                {
                    min = myArray[i];
                }
            }
            pocetMin = 0; //nastavím počet mého minima na nulu
            for (int i = 0; i < index; i++) //projedu celé pole
            {
                if (myArray[i] == min) //pokud najdu moje minimum, přídám počet minim...
                    pocetMin++;
            }
            textBoxVysledek.Text = "nejmenší číslo je " + min.ToString() + //vypíšu výsledky do textBoxVysledek
            Environment.NewLine; //začne psát v textboxu na nový řádek
            textBoxVysledek.Text += "počet výskytů je " + pocetMin.ToString();

        }
    }
}
