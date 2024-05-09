using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._6.List___základní_operace
{
    public partial class Form1 : Form
    {
        //Vytvořte program s grafickým rozhraním s tlačítky umožňující realizovat základní operace s datovým typem List:        //
        //- vložení jména zadaného přes textové pole na konec Listu
        //- vložení jména zadaného přes textové pole na začátek Listu
        //- zrušení posledního prvku
        //- zrušení prvního prvku
        //- abecední setřídění prvků
        //- výpis odřádkovaného obsahu listu do Messageboxu
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> nameList = new List<string>(); //můj list kam budu dávat jména

        private void buttonToEnd_Click(object sender, EventArgs e)
        {
            nameList.Add(textBoxVstup.Text); //klasický Add přidá nakonec listu
            textBoxVstup.Text = string.Empty; 
            //string.Empty je stejný jako bych napsal: textBoxVstup.Text = ""; -> vyprázdní textBox
        }
        private void buttonToStart_Click(object sender, EventArgs e)
        {
            nameList.Insert(0, textBoxVstup.Text); //insert vloží prvek na daný index
            //index = 0 -> vloží na první místo
            textBoxVstup.Text = string.Empty;
        }
        private void buttonDelLast_Click(object sender, EventArgs e)
        {
            int last = nameList.Count - 1; //List.Count funguje jako Lenght u Pole
            nameList.RemoveAt(last); //last je počet členů - 1 = poslední index -> vymaže poslední
        }
        private void buttonDelFirst_Click(object sender, EventArgs e)
        {
            nameList.RemoveAt(0); //RemoveAt(index jehož hodnotu chceš vymazat)
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            nameList.Sort(); //sort() -> setřídí list
        }
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            string vypis = ""; //nový prázdný string
            foreach (string name in nameList) 
            //foreachem si do stringu výpis přidám všechny jména z listu,
            //protože messageBox neumí vypsat List a tak potřebuju string
            {
                vypis += name + Environment.NewLine;
            }
            MessageBox.Show(vypis);
        }
    }
}
