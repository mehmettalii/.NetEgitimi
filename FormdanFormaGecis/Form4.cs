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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form3 BaseForm;

        public string Mesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  //Form3, form4 ü açtıktan sonra form3 ile bağı kopuyor. geri dönüş göndermek için dialogResult kullanıyoruz.

            BaseForm.Mesaj = textBox1.Text; // form3 e veri gönderdik

            this.Close();
        }

        int y = -500;

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(350, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 5;

            this.Location = new Point(300, y);

            if (y >= 150)
            {

                timer1.Enabled = false;
            }
        }
    }
}
