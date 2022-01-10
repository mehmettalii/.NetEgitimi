using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Marka = "Apple";
            bilgisayar.Model = "MacPro-3";
            bilgisayar.Fiyat = 30000;

            double kdvlifiyat = bilgisayar.KDVliFiyat;

            // Bunu yapabilmesi için class da override yaptık.

            listBox1.Items.Add(bilgisayar);
        }
    }
}
