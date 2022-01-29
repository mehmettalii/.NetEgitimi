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

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList Kisiler = new ArrayList();


        bool guncellemeMi = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //Enum
            Kisi kisi1 = new Kisi();
            kisi1.Gender = Cinsiyet.Erkek;
            kisi1.Ad = "Bilge";
            kisi1.Soyad = "Adam";

            int deger1 = (int)Cinsiyet.Erkek;

            string[] Cinsiyetler = Enum.GetNames(typeof(Cinsiyet)); //Enum içindeki değerlerin tümünü string olarak çektik

            Cinsiyet c= (Cinsiyet)Enum.Parse(typeof(Cinsiyet), "Erkek"); // çektiğimiz string değeri tekrar enum a atamak için elimizdeki string değeri enum a çevirdik.

            double PI=Matematik.PI; //Değişmeyen sabit sayıları static bir class veya class ta static bir değişken olarak tanımlayıp kullanabiliriz. ancak bu kullanımı class veya değer static olduğu için instance yapmadan kullanırız.

            int kid = 3;
            if (kid==Rol.AdminRolu)
            {
                //Yapılacak işlem
            }

            */

            //comboBox1.Items.Add("Erkek");
            //comboBox1.Items.Add("Kadın");

            foreach (var item in Enum.GetValues(typeof(Cinsiyet)))
            {
                comboBox1.Items.Add(item.ToString());
            };

            //comboBox2.Items.Add("Pazartesi");
            //comboBox2.Items.Add("Salı");
            //comboBox2.Items.Add("Çarşamba");
            //comboBox2.Items.Add("Perşembe");
            //comboBox2.Items.Add("Cuma");
            //comboBox2.Items.Add("Cumartesi");
            //comboBox2.Items.Add("Pazar");

            foreach (var item in Enum.GetValues(typeof(Gunler)))
            {
                comboBox2.Items.Add(item.ToString());
            };

            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();

            kisi.Ad = textBox1.Text;
            kisi.Soyad = textBox2.Text;
            kisi.IzinGunu = (Gunler)Enum.Parse(typeof(Gunler), comboBox2.SelectedItem.ToString());
            kisi.Gender = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), comboBox1.SelectedItem.ToString());

            if (guncellemeMi == false)
            {
                Kisiler.Add(kisi); //Kisiler.cs de override etmeyi unutma.
                label1.Text = "Yeni Kişi Eklendi";
                timer1.Enabled = true;
            }
            else
            {
                int selectedIndex = listBox1.SelectedIndex;
                Kisiler[selectedIndex] = kisi;
                button1.Text = "Ekle";
                guncellemeMi = false;

                label1.Text = "Kişi Güncellendi";
                timer1.Enabled = true;
            }

            listBox1.Items.Clear();
            foreach (var item in Kisiler)
            {

                listBox1.Items.Add(item);
            }


            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Kisi item = (Kisi)Kisiler[listBox1.SelectedIndex];

                textBox1.Text = item.Ad.ToString();
                textBox2.Text = item.Soyad.ToString();
                comboBox2.Text = item.IzinGunu.ToString();
                comboBox1.Text = item.Gender.ToString();


                button1.Text = "Kaydet";

                guncellemeMi = true;
            }
            else
            {
                MessageBox.Show("Bir Kişi Seçiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Silmek istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (sil == DialogResult.Yes)
            {
                Kisiler.Remove(listBox1.SelectedItem);
                listBox1.DataSource = null;
                listBox1.DataSource = Kisiler;


                label1.Text = "Kişi Silindi";
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "";
        }
    }
}
