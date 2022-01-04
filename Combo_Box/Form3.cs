using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seçiniz");
            comboBox1.Items.Add("ilkokul");
            comboBox1.Items.Add("lise");
            comboBox1.Items.Add("üniversite");
            comboBox1.Items.Add("yüksek Lisans");
            comboBox1.Items.Add("diğer");

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string ogrenimDurumu = comboBox1.Text;
            string medeniDurum;

            if (checkBox1.Checked == true)
            {
                medeniDurum = "evli";
            }
            else
            {
                medeniDurum = "bekar";
            }
            if (ad == "" || soyad == "" || ogrenimDurumu == "")
            {
                MessageBox.Show("Bütün bilgileri doldurduğunuzdan emin olunuz");
            }
            else
            {
                listBox1.Items.Add(ad + "," + soyad + "," + ogrenimDurumu + "," + medeniDurum);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = 0;
                checkBox1.Checked = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
                return;
            }
            string bilgiler = listBox1.Text;
            string[] bilgilerDizisi = bilgiler.Split(',');

            textBox1.Text = bilgilerDizisi[0];
            textBox2.Text = bilgilerDizisi[1];
            comboBox1.SelectedItem = bilgilerDizisi[2];
            checkBox1.Checked = bilgilerDizisi[3] == "evli";

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
                return;
            }
            if (MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
