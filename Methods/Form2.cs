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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            EnBuyuk(sayi1, sayi2, sayi3);
        }

        int EnBuyuk(int sayi1, int sayi2, int sayi3)
        {
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                int buyuk = sayi1;
                label1.Text = sayi1.ToString();
                return buyuk; ;
            }

            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                int buyuk = sayi2;
                label1.Text = sayi2.ToString();
                return buyuk; ;
            }
            else
            {
                int buyuk = sayi3;
                label1.Text = sayi3.ToString();
                return buyuk; ;
            }

        }
    }
}
