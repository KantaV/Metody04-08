using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMocnina_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " na " + textBox2.Text + " je " + Metody.Mocnina(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }

        private void buttonFaktorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faktorial " + textBox3.Text + " je " + Metody.Faktorial(int.Parse(textBox3.Text)));
        }

        private void buttonCifLichSoucet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Součet lichých cifer je " + Metody.CifLichSoucet(int.Parse(textBox4.Text)));
        }

        private void buttonJePrvosiclo_Click(object sender, EventArgs e)
        {
            bool prvociselnost = Metody.JePrvocislo(int.Parse(textBox5.Text));
            if (prvociselnost) MessageBox.Show("Je prvočíslo");
            else MessageBox.Show("Není prvočíslo");
        }

        private void buttonPocetDelSud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Počet sudých dělitelů je " + Metody.PocetSudDel(int.Parse(textBox6.Text)));
        }

        private void buttonNejSpolDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Největší společný dělitel je " + Metody.NejevetsiSpolecnyDelitel(int.Parse(textBox7.Text), int.Parse(textBox8.Text)));
        }
    }
}
