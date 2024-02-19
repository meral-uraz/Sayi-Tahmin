using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int tahmin1, tahmin2, tutulan;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tahmin1 = Convert.ToInt16(textBox1.Text);
            tahmin2 = Convert.ToInt16(textBox2.Text);
            int yakinlik1 = Math.Abs(tutulan - tahmin1);
            int yakinlik2 = Math.Abs(tutulan - tahmin2);

            if (tahmin1 == tahmin2)
            {
                button2.Text = "AYNI TAHMİNDE BULUNMAYINIZ";
            }
            else if (yakinlik1 >= yakinlik2)
            {
                button2.Text = "TUTULAN : " + tutulan + " KAZANAN : 2. OYUNCU";
            }

            else if (yakinlik2 >= yakinlik1)
            {
                button2.Text = "TUTULAN : " + tutulan + " KAZANAN : 1. OYUNCU";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tutulan = r.Next(1, 101);
        }

    }
}