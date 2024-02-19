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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int tahmin1, tahmin2,tahmin3, tutulan;

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tutulan = r.Next(1, 101);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tahmin1 = Convert.ToInt16(textBox1.Text);
            tahmin2 = Convert.ToInt16(textBox2.Text);
            tahmin3 = Convert.ToInt16(textBox3.Text);

            int yakinlik1 = Math.Abs(tutulan - tahmin1);
            int yakinlik2 = Math.Abs(tutulan - tahmin2);
            int yakinlik3 = Math.Abs(tutulan - tahmin3);

            if (tahmin1 == tahmin2 || tahmin1== tahmin3 || tahmin3 == tahmin2)
            {
                button2.Text = "AYNI TAHMİNDE BULUNMAYINIZ";
            }
            else if (yakinlik1 <= yakinlik2 && yakinlik1 <=yakinlik3 )
            {
                button2.Text = "TUTULAN : " + tutulan + " KAZANAN : 1. OYUNCU";
            }

            else if (yakinlik2 <= yakinlik1 && yakinlik2 <= yakinlik3)
            {
                button2.Text = "TUTULAN : " + tutulan + " KAZANAN : 2. OYUNCU";
            }

            else if (yakinlik3 <= yakinlik1 && yakinlik3 <= yakinlik2)
            {
                button2.Text = "TUTULAN : " + tutulan + " KAZANAN : 3. OYUNCU";
            }
        }
    }
}