using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string metin = "Bilge Adam";

            string metin2 = metin.ToLower();

            string metin3 = metin.ToUpper();

            bool varMi = metin.ToLower().Contains("adam");

            bool basliyorMun = metin.StartsWith("Bil");

            bool bitiyorMu = metin.EndsWith("dam");

            int index = metin.IndexOf("a"); // Birden fazla varsa ilk gördüğününün index'ini verir. Bulamazsa -1 verir.

            int lastIndex = metin.ToLower().LastIndexOf("a");

            string metin4 = metin.Remove(5);// 5'inci karakterden sonrasını siler.

            string metin5 = metin.Remove(5, 1);// 5'inci karakterden sonra 1 karakter sil.

            string metin6 = metin.Replace("Adam", "İnsan");

            string renkler = "siyah,sarı,yeşil,turuncu,mavi";

            string[] renkDizisi = renkler.Split(',');

            string yesil = renkDizisi[2];

            string metin7 = metin.Insert(5, "Büyük"); //5'inci indexten sonra "Büyük" ekledik.

            string metin8 = metin.Substring(6, 4); //adam

            char[] metinArray = metin.ToCharArray();

            string metin9 = metin.Trim(); //baştaki ve sondali boşluğu silmek için.
        }
    }
}
