using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM5._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, toplam;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            toplam = sayı1 + sayı2;
            label2.Text = toplam.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, fark;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            fark = sayı1 - sayı2;
            label2.Text = fark.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, carpim;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            carpim = sayı1 * sayı2;
            label2.Text = carpim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            {
                double sayı1, sayı2, bolme;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            bolme = sayı1 / sayı2;
            label2.Text = bolme.ToString(); 
            }
            catch(Exception hata)
            {
                MessageBox.Show("Sayıları uygun giriniz.", hata.Message);
            }
        }

      
    }
}
