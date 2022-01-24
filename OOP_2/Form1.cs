using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biscolata biscolata = new Biscolata();
            biscolata.Fiyat = 100;

            Ekmek ekmek = new Ekmek();
            ekmek.Fiyat = 10;

            decimal fiyat1 = biscolata.KDVliFiyatHesapla();
            decimal fiyat2 = ekmek.KDVliFiyatHesapla();

            decimal fiyat3 = SatisFiyati(biscolata);
            decimal fiyat4 = SatisFiyati(ekmek);
        }

        //Çok biçimlilik/Polimorfizm
        decimal SatisFiyati(Urun urun)
        {
            return urun.KDVliFiyatHesapla();
        }
    }
}
