using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Düzenle(textBox1.Text);
        }

        void Düzenle(string metin)
        {
            string gelen = textBox1.Text.ToLower();
            gelen = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(gelen);
            listBox1.Items.Add(gelen);
            listBox1.Refresh();
            textBox1.Clear();

        }
    }
}
