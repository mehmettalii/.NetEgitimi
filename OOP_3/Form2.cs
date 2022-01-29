using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Referance type-referans tip
            // Value type-değer tip

            Kisi kisi1 = new Kisi();
            kisi1.Gender = Cinsiyet.erkek;
            kisi1.Ad = "Bilge";
            kisi1.Soyad = "Adam";

            Test(kisi1); // Test diye method tanımlayıp içerisinde kisi1 i atarsak yine kisi1 in değeri değişmiş olur. Referance type daki gibi.

            Kisi kisi2 = kisi1;
            kisi2.Ad = "Ermiş"; //Referance type olduğu için bu atama kisi1 i de değiştirecek.

            Kisi kisi3 = new Kisi(); // kisi1 i etkilemesin istiyorsak burada olduğu gibi properties i atuyoruz.
            kisi3.Ad = kisi1.Ad;

            int sayi1 = 1;
            int sayi2 = sayi1;
            sayi2 = 5; // value type olduğu içn bu atama sayi1 i değiştirmeyecek.
        }

        void Test(Kisi kisi)
        {
            kisi.Ad = "Veli";
        }

    }
}
