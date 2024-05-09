using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2.Práce_s_textovým_souborem
{
    using System.IO; //vždy pro práci s textovými soubory, stejné jako using System.Drawing pro kreslení
    public partial class Form1 : Form
    {
        //Vytvořte textový soubor obsahující jména zadávaná postupně uživatelem do textového pole.
        //Následně obsah souboru vypište do listboxu.
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter zapisovac;
        StreamReader ctecka;
        private void Form1_Load(object sender, EventArgs e)
        {
            zapisovac = new StreamWriter("jmena.txt"); //nová instance třídy StreamWriter s názvem "jmena.txt"
            zapisovac.WriteLine(""); //nutno na začátku vymazat obsah souboru
            zapisovac.Close();
            //musím ten soubor pro zápis vytvořit hned při načtení formuláře,
            //jinak bych ho načítal až když do něj chci něco zapsat a to by vytvářelo problémy
        }
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            zapisovac = new StreamWriter("jmena.txt", true);
            //parametr true říká, že další položky se přidávají na konec souboru a tím pádem je nemusím vypisovat po jednom
            zapisovac.WriteLine(textBoxVstup.Text);
            zapisovac.Close(); //na konci musí bejt vždycky close
            textBoxVstup.Text = string.Empty; //po uložení do sešitu se txtbox vymaže
        }
        private void buttonPrintFile_Click(object sender, EventArgs e)
        {
            ctecka = new StreamReader("jmena.txt"); //nová instanci StreamReader pro čtení ze souboru "jmena.txt"
            string radek = ctecka.ReadLine();
            while (radek != null) //nebo taky radek != string.Empty
            { //prostě dokud není prázdný čte dál
                listBoxVystup.Items.Add(radek);
                radek = ctecka.ReadLine();
            }
            ctecka.Close(); //na konci musí bejt vždycky close
        }

        /* nějaký info k práci s .txt souborama:
         * 
         * na začátku vždy připsat: using System.IO;
         * stejné jako using System.Drawing pro kreslení
         * 
         * konstruktor třídy StreamWriter nebo StreamReader k vytvoření nové instance ->
         * StreamWriter jméno instance;
         * jméno instance = new StreamWriter("jméno souboru.txt");
         * 
         * StreamReader jméno instance;
         * jméno instance = new StreamReader("jméno souboru.txt");
         * 
         * důležité ten soubor pro zápis vytvořit hned při načtení formuláře/konzole,
         * jinak bych ho načítal až když do něj chci něco zapsat a to by vytvářelo problémy
         * taky musí být ze začátku prázdný -> jméno instance.WriteLine("");
         * 
         * jména insatncí jsou různá ale jméno souboru musí být stejné
         * 
         * když napíšu za jméno souboru ještě true - StreamWriter("jméno souboru.txt", true);
         * tak tím říkám že se budou slova přidávat vždy na konec souboru
         * 
         * metody Write, WriteLine, Read, ReadLine
         * 
         * Po zápisu je důležité uzavřít instanci StreamWriter voláním metody Close - jak StreamWriter, tak StreamReader
         * 
         * 
        */


    }
}
