using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Ekmek : Urun
    {
        public override decimal KDVliFiyatHesapla()
        {
            return Fiyat * 1.00m;
        }

        public override void StokSay() // Urunde StokSay methodunu abstract olarak belirlediğimiz için burada bunu yazmak zorundayız.
        {
            throw new NotImplementedException();
        }
    }
}
