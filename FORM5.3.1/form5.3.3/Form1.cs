using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form5._3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            label1.Visible = true;
            if(indirimcheckBox1.Checked)
            {
                sonuc = sayi1 * 0.90;
                label1.Text = sonuc.ToString();
            }
        }
    }
}
