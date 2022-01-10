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

namespace Classes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        ArrayList Urunler = new ArrayList();

        bool guncellemeMi = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            //urun.Ad = textBox1.Text;
            //urun.Fiyat = Convert.ToDouble(textBox3.Text);
            //urun.StokMiktari = Convert.ToInt32(textBox2.Text);
            //urun.UretimTarihi = dateTimePicker1.Value;

            //Urunler.Add(urun);

            //foreach (var item in Urunler)
            //{
            //    listBox1.Items.Add(item);
            //}

            if (guncellemeMi == false)
            {
                urun.Ad = textBox1.Text;
                urun.Fiyat = Convert.ToDouble(textBox3.Text);
                urun.StokMiktari = Convert.ToInt32(textBox2.Text);
                urun.UretimTarihi = dateTimePicker1.Value;

                Urunler.Add(urun);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                Temizle();
            }
            else
            {
                int selectedIndex = listBox1.SelectedIndex;
                urun.Ad = textBox1.Text;
                urun.Fiyat = Convert.ToDouble(textBox3.Text);
                urun.StokMiktari = Convert.ToInt32(textBox2.Text);
                urun.UretimTarihi = dateTimePicker1.Value;
                Urunler[selectedIndex] = urun;
                button1.Text = "Ekle";
                guncellemeMi = false;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                Temizle();
            }

            listBox1.Items.Clear();

            foreach (var item in Urunler)
            {
                //listBox1.DataSource = null;
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun urun = (Urun)Urunler[listBox1.SelectedIndex]; //RunTime Kontrolde yaptık.

            label1.Text = urun.Ad;
            label2.Text = urun.Fiyat.ToString();
            label3.Text = urun.StokMiktari.ToString();
            label4.Text = urun.UretimTarihi.ToString();
            label5.Text = urun.SonKullanmaTarihi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)Urunler[listBox1.SelectedIndex]; //RunTime Kontrolde yaptık.

            textBox1.Text = urun.Ad;
            textBox3.Text = urun.Fiyat.ToString();
            textBox2.Text = urun.StokMiktari.ToString();
            //dateTimePicker2 =Convert.ToDateTime( urun.UretimTarihi);

            button1.Text = "Kaydet";

            Temizle();

            guncellemeMi = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Silmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (sil == DialogResult.Yes)
            {
                Urunler.Remove(listBox1.SelectedItem);
                listBox1.Items.Clear();

                Temizle();

                foreach (var item in Urunler)
                {
                    //listBox1.DataSource = null;
                    listBox1.Items.Add(item);
                }
            }
        }

        void Temizle() //Parametre almayacaksa
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }
    }
}
