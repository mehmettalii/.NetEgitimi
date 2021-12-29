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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;

            label1.Text = Convert.ToString(zaman);

            label2.Text = zaman.ToLongDateString();

            label3.Text = zaman.ToShortDateString();

            label4.Text = zaman.ToLongTimeString();

            label5.Text = zaman.ToShortTimeString();

            label6.Text = zaman.Year + "/" + zaman.Month + "/" + zaman.Day + "/" + zaman.Hour + ":" + zaman.Minute;

            label7.Text = zaman.DayOfWeek.ToString();

            label8.Text = DateTime.IsLeapYear(zaman.Year) == true ? "Artık Yıl" : "Artık Yıl Değil";
            DateTime besGunSonrakiTarih = DateTime.Now.AddDays(5);

            //label9.Text = besGunSonrakiTarih.ToString();

            DateTime besGunOncekiTarih = DateTime.Now.AddDays(-5);

            //label10.Text = besGunSonrakiTarih.ToString();

            TimeSpan fark = DateTime.Now - besGunSonrakiTarih;

            label9.Text = fark.Days.ToString();
        }
    }
}
