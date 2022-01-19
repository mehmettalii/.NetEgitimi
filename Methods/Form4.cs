using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        string[] karakter = { "a", "e", "u", "ı", "o", "ü", "i", "ö" };

        void SesliMi(string deger)

        {
            string gelen = textBox1.Text.ToLower();

            if (karakter.Contains(gelen))
            {
                listBox1.Items.Add(deger);
                listBox1.Refresh();
                textBox1.Clear();
            }
            else
            {
                listBox2.Items.Add(deger);
                listBox2.Refresh();
                textBox1.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SesliMi(textBox1.Text);
        }
    }
}
