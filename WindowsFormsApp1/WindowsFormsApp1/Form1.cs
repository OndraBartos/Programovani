using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mujCudlik_Click(object sender, EventArgs e)
        {
            mujCudlik.Text = "klik vole";
            label1.Text = textBox1.Text;
            progressBar1.Value += 5;
        }
        private void mujCudlik2_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
        }
    }
}
