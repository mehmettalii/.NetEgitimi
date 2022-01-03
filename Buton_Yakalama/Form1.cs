using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buton_Yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deger = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = deger.ToString();
            deger++;

            if (deger > 5)
            {
                timer1.Interval = 600;
            }
            else if (deger > 10)
            {
                timer1.Interval = 500;
            }
            else if (deger > 15)
            {
                timer1.Interval = 500;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int koordinatX = rastgele.Next(0, 600);
            int koordinatY = rastgele.Next(0, 300);

            button1.Location = new Point(koordinatX, koordinatY);
        }
    }
}
