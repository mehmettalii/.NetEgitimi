using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihselIslemler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToDecimal(DateTime.Now.Hour);
            numericUpDown2.Value = Convert.ToDecimal(DateTime.Now.Minute);
            numericUpDown3.Value = Convert.ToDecimal(DateTime.Now.Second);
        }

        decimal saat, dakika, saniye;

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                string[] timeDizi = item.ToString().Split(':');

                if (
                    DateTime.Now.Hour.ToString() == timeDizi[0] &&
                    DateTime.Now.Minute.ToString() == timeDizi[1] &&
                    DateTime.Now.Second.ToString() == timeDizi[2])
                {
                    MessageBox.Show("Uyan");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            saat = numericUpDown1.Value;
            dakika = numericUpDown2.Value;
            saniye = numericUpDown3.Value;

            string time = saat + ":" + dakika + ":" + saniye;

            listBox1.Items.Add(time);
        }
    }
}
