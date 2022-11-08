using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorgraficzny
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operacja = "";
        bool operacja_klikniecie = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((wynik.Text == "0")||(operacja_klikniecie))
            {
                wynik.Clear();
            }
            operacja_klikniecie = false;
            Button b = (Button)sender;
            wynik.Text = wynik.Text + b.Text;
        }

        private void buttonusunwszystko_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
        }

        private void button_operacje(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacja = b.Text;
            value = Double.Parse(wynik.Text);
            operacja_klikniecie = true;
            obliczenia.Text = value + " " + operacja;
        }

        private void buttonrownasie_Click(object sender, EventArgs e)
        {
            obliczenia.Text = "";
            switch (operacja)
            {
                case "+":
                    wynik.Text = (value + Double.Parse(wynik.Text)).ToString();
                    break;
                case "-":
                    wynik.Text = (value - Double.Parse(wynik.Text)).ToString();
                    break;
                case "*":
                    wynik.Text = (value * Double.Parse(wynik.Text)).ToString();
                    break;
                case "/":
                    wynik.Text = (value / Double.Parse(wynik.Text)).ToString();
                    break;
                default:
                    break;

            }
            operacja_klikniecie = false;
        }

        private void buttonusun_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
            value = 0; 
        }


        private void button11_Click(object sender, EventArgs e)
        {
            Form2 okienko = new Form2();
            okienko.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
