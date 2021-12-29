using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosul_Ifadeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 
            switch(degisken)
            {
            case deger1;
            {
            break;
            }
            case deger2;
            {
            break;
            }
            default: (zorunlu değil ihtiyaç varsa kullan)
            {
            
            }

            yada
             switch(degisken)
            {
            case deger1;
            case deger2;
            {
            break;
            }
            default: (zorunlu değil ihtiyaç varsa kullan)
            {
            
            }
            
             */


            /*
            double sayi = Convert.ToDouble(textBox1.Text);
            string sonuc = sayi % 2 == 0 ? "sayi cift" : "sayi tek";
            label1.Text = sonuc;
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aylar = textBox1.Text;

            switch (aylar)
            {
                case "kış":
                    label1.Text = "Aralık, Ocak, Şubat";
                    {
                        break;
                    }
                case "yaz":
                    label1.Text = "Haziran, Temmuz, Ağustos";
                    {
                        break;
                    }
                case "ilkbahar":
                    label1.Text = "Mart, Nisan, Mayıs";
                    {
                        break;
                    }
                case "sonbahar":
                    label1.Text = "Eylül, Ekim, Kasım";
                    {
                        break;
                    }
            }
        }
    }
}
