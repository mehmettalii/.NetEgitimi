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

namespace FormdanFormaGecis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        ArrayList renkler = new ArrayList();

        public string Mesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(); // instance aldık.

            frm4.BaseForm = this; // Formlar arası veri aktarmak için yaptık. Form4 deki public verilere ulaşabiliriz.


            DialogResult sonuc = frm4.ShowDialog();

            if (sonuc == DialogResult.OK)
            {



                renkler.Add(Mesaj);
                listBox1.Items.Clear();

                foreach (var item in renkler)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
    }
}
