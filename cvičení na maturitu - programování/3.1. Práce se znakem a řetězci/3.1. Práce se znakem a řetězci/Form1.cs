using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1.Práce_se_znakem_a_řetězci
{
    public partial class Form1 : Form
    {
        //Připravte program na základní metody pro práci se stringem - operace realizujte vždy stiskem tlačítka:
        //1, Převeďte zadaný řetězec na velká písmena
        //2, Odstraňte ze zadaného řetězce mezery
        //- počáteční a koncové mezery
        //- mezery mezi slovy
        //3, Rozdělte řetězec na více podřetězců, jako oddělovač zvolte mezeru
        //4, Vložte do řetězce znak a to na zadanou pozici
        //5, Odstraňte z řetězce znak na zadané pozici

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonToUpper_Click(object sender, EventArgs e) //přecede na velký písmena
        {
            textBoxVysledek.Text = string.Empty; //vymaže vysledkovej textBox vždy předtim než tam budu něco psát
            textBoxVysledek.Text += textBoxVstup.Text.ToUpper();
        }
        private void buttonDelGap_Click(object sender, EventArgs e) //vymaže mezery
        {
            textBoxVysledek.Text = string.Empty;
            string text = textBoxVstup.Text; //to co jsem napsal do textBoxVstup je jeden dlouhej string
            //List<string> myList = new List<string>();
            //foreach (string s in text.Split(' '))
            //{   // rozdělim ten dlouhej string všude kde je mezera a foreahem ho uložim do Listu
            //    myList.Add(s);
            //}
            List<string> myList = new List<string>(text.Split(' ')); //jde i jenom timhle
            foreach (string s in myList) //vypíšu ten List
            {
                textBoxVysledek.Text += s;
            }
        }
        private void buttonSplit_Click(object sender, EventArgs e) //rozdělí na jednotlivý řetězce
        {
            textBoxVysledek.Text = string.Empty;
            string text = textBoxVstup.Text; //to co jsem napsal do textBoxVstup je jeden dlouhej string
            //text.Split(' '); //rozdělím ho na každém místě kde je mezera
            //List<string> myList = new List<string>(); 
            //foreach (string s in text.Split(' ')) 
            //{   // rozdělim ten dlouhej string všude kde je mezera a foreahem ho uložim do Listu
            //    myList.Add(s);
            //}
            List<string> myList = new List<string>(text.Split(' ')); //jde i jenom timhle
            foreach (string s in myList) //vypíšu ten List
            {
                textBoxVysledek.Text += s + Environment.NewLine;
            }
        }
        private void buttonAddToIndex_Click(object sender, EventArgs e) //přidá znak na index
        {
            textBoxVysledek.Text = string.Empty;
            string text = textBoxVstup.Text; //to co jsem napsal do textBoxVstup je jeden dlouhej string            
            List<string> listPismen = new List<string>();
            foreach (char p in text)
            {
                string pismeno = p.ToString();
                listPismen.Add(pismeno);                
            }
            //do toho listuPísmen přidám ten můj znak Insertem()
            string znak = textBoxZnak.Text; //písmeno co chci vložit
            int index = Convert.ToInt32(textBoxPozice.Text) - 1; //index na který ho chci vložit
            listPismen.Insert(index, znak);
            foreach (string s in listPismen)
            {
                textBoxVysledek.Text += s;
            }
        }
        private void buttonDelAtIndex_Click(object sender, EventArgs e) //vymaže znak na indexu
        {
            textBoxVysledek.Text = string.Empty;
            string text = textBoxVstup.Text; //to co jsem napsal do textBoxVstup je jeden dlouhej string            
            List<string> listPismen = new List<string>();
            foreach (char p in text)
            {
                string pismeno = p.ToString();
                listPismen.Add(pismeno);
            }
            //z toho listuPísmen odeberu znak na chtěným indexu RemoveAt()
            int index = Convert.ToInt32(textBoxPozice.Text) - 1; //index kterej chci odebrat
            listPismen.RemoveAt(index);
            foreach (string s in listPismen)
            {
                textBoxVysledek.Text += s;
            }

        }
    }
}
