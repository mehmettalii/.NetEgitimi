using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Gender { get; set; }

        public Gunler IzinGunu { get; set; }

        // listbox a yazdırabilmek için bunu yapmamız gerekiyor.
        public override string ToString()
        {
            return Ad + " , " + Soyad + " , " + Gender + " , " + IzinGunu;
        }
    }
}
