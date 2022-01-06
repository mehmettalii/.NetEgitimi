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

namespace Array_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList iller = new ArrayList();

        bool guncellemeMi = false;


        private void button1_Click(object sender, EventArgs e)
        {
            //string il = textBox1.Text;
            //if (iller.Contains(il) == true)
            //{
            //    MessageBox.Show("Bu il zaten ekli");
            //    textBox1.Clear();
            //}
            //else
            //{
            //    iller.Add(il);

            //    //DataSource nin alternatifi
            //    listBox1.Items.Clear();

            //    foreach (var item in iller)
            //    {
            //        listBox1.Items.Add(item);
            //    }

            //    //listBox1.DataSource = null;
            //    //listBox1.DataSource = iller;
            //    textBox1.Clear();
            //    textBox1.Focus();
            //}

            string il = textBox1.Text;
            if (guncellemeMi == false)
            {
                iller.Add(il);
            }
            else
            {
                int selectedIndex = listBox1.SelectedIndex;
                iller[selectedIndex] = il;
                button1.Text = "Ekle";
                guncellemeMi = false;
            }

            listBox1.Items.Clear();
            foreach (var item in iller)
            {
                listBox1.Items.Add(item);
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = listBox1.SelectedItem.ToString();
            //iller.Remove(listBox1.SelectedItem);
            //listBox1.DataSource = null;
            //listBox1.DataSource = iller;
            int selectedIndex = listBox1.SelectedIndex;
            string seciliIl = iller[selectedIndex].ToString();
            textBox1.Text = seciliIl;
            button1.Text = "Kaydet";

            guncellemeMi = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Silmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (sil == DialogResult.Yes)
            {
                iller.Remove(listBox1.SelectedItem);
                listBox1.DataSource = null;
                listBox1.DataSource = iller;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
