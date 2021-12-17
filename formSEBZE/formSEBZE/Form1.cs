using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formSEBZE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> fiyatlar = new Dictionary<string, int>();
            fiyatlar.Add("Domates", 7);
            fiyatlar.Add("Patates", 5);
            fiyatlar.Add("Patlıcan", 15);
            fiyatlar.Add("Biber", 12);


            foreach (var item in fiyatlar.Keys)
            {
                secilenSebzeler_Listbox.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text);
            string secili = secilenSebzeler_Listbox.SelectedItem.ToString();
            secilenSebzeler_Listbox.Items.Add(secili);

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string secili = secilenSebzeler_Listbox.SelectedItem.ToString();
            secilenSebzeler_Listbox.Items.Remove(secili);
        }

        private void listSebzeler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
