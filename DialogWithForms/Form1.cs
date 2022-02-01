using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogWithForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Cevap Answer;
        public string Metin;
        public string Title;

        private void button1_Click(object sender, EventArgs e)
        {
            Answer = (Cevap)Enum.Parse(typeof(Cevap), comboBox1.SelectedItem.ToString());
            Title = textBox1.Text;
            Metin = textBox2.Text;

            Form2 frm2 = new Form2(Title, Metin, Answer); // instance aldık.

            frm2.BaseForm = this; // Formlar arası veri aktarmak için yaptık. Form2 deki public verilere ulaşabiliriz.        

            frm2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Cevap)))
            {
                comboBox1.Items.Add(item.ToString());
            };
        }
    }
}
