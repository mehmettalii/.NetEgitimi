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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mavi");
            listBox1.Items.Add("Sarı");
            listBox1.Items.Add("Kırmızı");
            listBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilen = listBox1.SelectedItem.ToString();
                int secilenIndex = listBox1.SelectedIndex;
                MessageBox.Show(secilen);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string renk = listBox1.SelectedItem.ToString();
            label1.Text = renk;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = null;
        }
    }
}
