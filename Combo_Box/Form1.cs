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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("mavi");
            comboBox1.Items.Add("yeşil");
            comboBox1.Items.Add("kırmızı");

            if (comboBox1.SelectedItem != null)
            {
                string secili = comboBox1.SelectedItem.ToString();
                int secilenIndex = comboBox1.SelectedIndex;
            }

            comboBox1.SelectedItem = "kırmızı";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
