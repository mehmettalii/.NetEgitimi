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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 BaseForm; //Formlar arası veri aktarmak için yaptık. Form1 e public verileri gönderebiliriz.

        public string Mesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            BaseForm.Mesaj = "Test"; // form1 e veri gönderdik
            this.DialogResult = DialogResult.OK;  //Form1, form2 yi açtıktan sonra form1 ile bağı kopuyor. geri dönüş göndermek için dialogResult kullanıyoruz.

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Mesaj; //Form1 den veri aldık.
        }
    }
}
