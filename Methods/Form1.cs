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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();

            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();

            Temizle();
            MesajGoster("Bilge Adam");
        }

        //Birdeb Fazla yerde kullanılan komutları method haline getiriyoruz.
        void Temizle() //Parametre almayacaksa
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        void MesajGoster(string mesaj) // Parametre alacaksa
        {
            MessageBox.Show(mesaj);
        }

        void MesajGoster(string mesaj1, string mesaj2) // Birden fazla Parametre alacaksa
        {
            MessageBox.Show(mesaj1, mesaj2);
        }

        int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        int Ornek(int sayi1, int sayi2, int? sayi3 = null)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

    }
}
