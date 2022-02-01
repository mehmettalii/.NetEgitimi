using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Mesaj; //Form2 den veri aldık.

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); // instance aldık.

            frm2.StartPosition = FormStartPosition.CenterScreen; //Form2 açıldığında ekranın ortasında olsun. Bu tarz başka özellikler var.

            frm2.BaseForm = this; // Formlar arası veri aktarmak için yaptık. Form2 deki public verilere ulaşabiliriz.

            frm2.Mesaj = "Bilge Adam"; //Form2 ye veri gönderdik.

            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 yi açtıktan sonra form1 ile bağı kopuyor. geri dönüş almak için dialogResult kullanıyoruz.
            Form2 frm2 = new Form2(); // instance aldık.

            frm2.BaseForm = this; // Formlar arası veri aktarmak için yaptık. Form2 deki public verilere ulaşabiliriz.

            frm2.Mesaj = "Bilge Adam"; //Form2 ye veri gönderdik.

            DialogResult sonuc = frm2.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                this.Text = Mesaj;
            }
        }
    }
}
