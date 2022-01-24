using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    abstract class Urun // Class ları tanımlarken başına abstract eklediğimizde instance si alınamaz. bu ifadeyi class ta tanımladığımız nesne soyut ise kullanıyoruz.
    {
        private string _marka;
        private string _adi;
        private decimal _fiyat;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public virtual decimal KDVliFiyatHesapla() //Bir metoodun farklı class larda farklı değer almasını/farklı çalışmasını istiyorsak virtual ekliyoruz. override ediyoruz.
        {
            return _fiyat * 1.18m;
        }

        public abstract void StokSay(); // methodu abstract olarak tanımladığımızda bu class tan inheritance alan classlara bu methodun implement edilmesini zorunlu kılıyoruz.
    }
}
