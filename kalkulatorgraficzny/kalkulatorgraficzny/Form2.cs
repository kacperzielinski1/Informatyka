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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 okienko = new Form1();
            okienko.Show();
            this.Hide();
        }
    }
}
