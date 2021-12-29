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
    public partial class Form4 : Form
    {
        DateTime? olumTarihi = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDay = dateTimePicker1.Value;
            //label2.Text = birthDay.ToString();

            DateTime now = DateTime.Now;
            //label3.Text = now.ToString();

            TimeSpan age = now - birthDay;

            Random rnd = new Random();
            int number = rnd.Next(50, 90);


            olumTarihi = birthDay.AddYears(number);
            //DateTime dogumTarihi = new DateTime(2021, 12, 27, 13, 20, 10);
            //TimeSpan fark = DateTime.Now - dogumTarihi;

            //yada

            //double yil = fark.TotalDays / 365;

            //double ayOndalik = yil - Math.Truncate(yil);
            //double kalanAy = ayOndalik * 12;
            //string kalanAyStr = Math.Floor(kalanAy).ToString() ?? "0";

            //double kalanGunOndalik = kalanAy - Math.Truncate(kalanAy);
            //double kalanGun = kalanGunOndalik * 30;
            //string kalanGunStr = Math.Floor(kalanGun).ToString() ?? "0";

            //double kalanSaatOndalik = kalanGun - Math.Truncate(kalanGun);
            //double kalanSaat = kalanSaatOndalik * 24;
            //string kalanSaatStr = Math.Floor(kalanSaat).ToString() ?? "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (olumTarihi != null)
            {
                var fark = (DateTime)olumTarihi - DateTime.Now;
                label1.Text = $"{fark.Days / 365} " + fark.ToString();
            }
        }
    }
}
