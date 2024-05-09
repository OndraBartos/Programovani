using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._7.Listbox___základní_operace
{
    public partial class Form1 : Form
    {
        //Vytvořte program s grafickým rozhraním s tlačítky umožňující realizovat základní operace s prvkem listbox:
        // - vložení jména zadaného přes textové pole na konec listboxu
        // - vložení jména zadaného přes textové pole na začátek listboxu
        // - vložení jména zadaného přes textové pole na zadanou pozici
        // - zrušení posledního prvku
        // - zrušení prvního prvku
        // - zrušení označeného prvku

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddToStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text); //stejný jako List - Insert přidá na zadaný index
            textBox1.Text = string.Empty; //vymazat textBox
        }
        private void buttonAddToEnd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); //stejný jako List - Add přidá na konec
            textBox1.Text = string.Empty; //vymazat textBox
        }
        private void buttonAddToIndex_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //vloží na vybraný index v listBoxu
            if (index >= 0) //musíme ověřit pro situaci kdy není nic vybráno
            {
                listBox1.Items.Insert(index, textBox1.Text);
                textBox1.Text = string.Empty; //vymazat textBox
            }
            else
            {
                MessageBox.Show("Nevybral jsi žádný index");
            }            
        }
        private void buttonDelFirst_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0); //vymaž první -> index = 0
        }
        private void buttonDelLast_Click(object sender, EventArgs e)
        {
            int index = listBox1.Items.Count - 1; //index = počet členů - 1 -> vymaže poslední index
            if (index >= 0) //musíme ověřit pro situaci kdy není nic vybráno
            {
                listBox1.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Nevybral jsi žádný index");
            }            
        }
        private void buttonDelIndex_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); //vymaže vybraný index
        }
    }
}
