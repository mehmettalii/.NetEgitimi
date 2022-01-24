using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Akilli_Telefon akilli_Telefon = new Akilli_Telefon();
            akilli_Telefon.Marka = "Apple";
            akilli_Telefon.KablosuzSarj = true;

            SamsungZFlip samsungZFlip = new SamsungZFlip();
            samsungZFlip.FotgrafCek();

            Nokia_6600 nokia_6600 = new Nokia_6600();
            nokia_6600.FotgrafCek();

            //Bir nesne türediği nesne gibi davranabilir.
            Cep_Telefonu cep_Telefonu1 = new Nokia_6600();  //Böyle yazdığımızda sadece cep_Telefonundaki özelliklere ulaşabiliriz.

            Nokia_6600 cep_Telefonu2 = (Nokia_6600)cep_Telefonu1; //Kendine has özelliklere de ulaşabilmek için bunu yapmamız gerekir. (cast ediyoruz)
        }
        void FotografCek(IFotoCekebilir fotografCekebilir)
        {
            //cep_Telefonu2'de fotoğraf çek methodu kullanmak için implement ettik
        }
    }
}
