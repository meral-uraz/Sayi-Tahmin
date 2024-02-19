using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int tahmin, tutulan, deneme;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tahmin = Convert.ToInt16(textBox1.Text);
                deneme++;

                if (tahmin > tutulan)
                {
                    button2.Text = "AŞAĞI";
                    textBox1.Text = "";
                }
                if (tahmin < tutulan)
                {
                    button2.Text = "YUKARI";
                    textBox1.Text = "";
                }
                if (tahmin == tutulan)
                {
                    if (deneme == 1)
                    {
                        button2.Text = "BÜYÜCÜ VAAAAAR!";
                        button2.Enabled = false;
                    }
                    else if (deneme >= 10)
                    {
                        button2.Text = deneme + " DENEMEDE BULDUN Bİ AN HİÇ BİTMEYECEK ZANNETTİM";
                        button2.Enabled = false;
                    }
                    else
                    {
                        button2.Text = deneme + " DENEMEDE BULDUNUZ";
                        button2.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tutulan = r.Next(1, 101);
            deneme = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt16(textBox1.Text);
            deneme++;

            if (tahmin > tutulan) button2.Text = "AŞAĞI";
            if (tahmin < tutulan) button2.Text = "YUKARI";
            if (tahmin == tutulan)
            {
                if (deneme == 1)
                {
                    button2.Text = "BÜYÜCÜ VAAAAAR!";
                    button2.Enabled = false;
                }
                else if (deneme >= 10)
                {
                    button2.Text = deneme + "DENEMEDE BULDUN! Bİ AN HİÇ BİTMEYECEK ZANNETTİM";
                    button2.Enabled = false;
                }
                else
                { 
                    button2.Text = deneme + " DENEMEDE BULDUNUZ";
                    button2.Enabled = false;
                }
            }
        }
    }
}