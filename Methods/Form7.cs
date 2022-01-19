using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        ArrayList kullanicilar = new ArrayList();
        int count = 0;

        void Eposta(string metin1, string metin2, string metin3)
        {
            string ad = textBox1.Text.ToLower();
            string soyad = textBox2.Text.ToLower();
            string uzanti = comboBox1.Text;
            string kullanici = ad + soyad + uzanti;



            if (!kullanicilar.Contains(kullanici))
            {
                kullanicilar.Add(kullanici);
                listBox1.Items.Add(kullanici);

                listBox1.Refresh();

                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                string yeniKullanici = kullanici.Split('@')[0];
                kullanici = yeniKullanici + count.ToString() + uzanti;
                count++;
                kullanicilar.Add(kullanici);
                listBox1.Items.Add(kullanici);

                listBox1.Refresh();

                textBox1.Clear();
                textBox2.Clear();
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            Eposta(textBox1.Text, textBox2.Text, comboBox1.Text);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seçiniz");
            comboBox1.Items.Add("@hotmail.com");
            comboBox1.Items.Add("@gmail.com");
            comboBox1.Items.Add("@outlook.com");

            comboBox1.SelectedItem = ("Seçiniz");
        }
    }
}
