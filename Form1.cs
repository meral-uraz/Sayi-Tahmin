using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sayi_Tahmin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "[^1-3]"))
            {
                MessageBox.Show("EN AZ 1 EN FAZLA 3 KİŞİ İLE OYNANIR");
                
                if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "4"))
                {
                    DialogResult dr = MessageBox.Show("ONUN YERİNE Bİ 101 / OKEY ATSANIZ", "OKEY / 101?", MessageBoxButtons.YesNo);
                    
                    if (dr == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "3"))
            {
                DialogResult dr = MessageBox.Show("BİR KİŞİ DAHA BULUP 101 / OKEY Mİ OYNASANIZ","OKEY / 101?",MessageBoxButtons.YesNo);
                
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "1"))
            {
                Form2 Form2 = new Form2();
                Form2.Dock = DockStyle.Fill;
                Form2.TopLevel = false;
                Form2.Parent = splitContainer1.Panel2;
                Form2.Show();
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "2"))
            {
                Form3 f = new Form3();
                f.Dock = DockStyle.Fill;
                f.TopLevel = false;
                f.Parent = splitContainer1.Panel2;
                f.Show();
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(comboBox1.Text, "3"))
            {
                Form4 f = new Form4();
                f.Dock = DockStyle.Fill;
                f.TopLevel = false;
                f.Parent = splitContainer1.Panel2;
                f.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("ÇIKMAK İSTİYOR MUSUNUZ?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}