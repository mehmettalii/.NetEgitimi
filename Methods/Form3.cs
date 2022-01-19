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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //string sayi = textBox1.Text;
        }

        //int TekMi(int sayi)
        //{
        //    int ciftSayilar =Convert.ToInt32(listBox1.Items);
        //    int tekSayilar = Convert.ToInt32(listBox2.Items);

        //    if (sayi%2==0)
        //    {
        //        ciftSayilar+=listBox1.Items.Add(sayi);
        //        return ciftSayilar;
        //    }
        //    tekSayilar+= listBox2.Items.Add(sayi);
        //    listBox2.Items.Add(sayi);
        //    return tekSayilar;

        //}

        void Check(string sayi)
        {
            if (Convert.ToInt32(sayi) % 2 == 0)
            {
                listBox1.Items.Add(sayi);
                listBox1.Refresh();
                textBox1.Clear();
            }
            else
            {
                listBox2.Items.Add(sayi);
                listBox2.Refresh();
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text);
        }
    }
}
