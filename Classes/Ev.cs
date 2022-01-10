using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Ev
    {
        public Ev()
        {
            //Nesneden instance alınırken ilk çalışan yer.
        }

        public Ev(string adres, int odaSayisi, double fiyat, bool kiralikMi) // Constructor oluşturduk ve adres atadık. form açıldığında adresi yazdırdığımız yer dolu olarak açılacak.
        {
            Adres = adres;
            OdaSayisi = odaSayisi;
            Fiyat = fiyat;
            KiralikMi = kiralikMi;

        }

        private string _adres;  // Field
        private int _odasayisi;
        private double _fiyat;
        private bool _kiralikMi;

        public string Adres // Properties
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public int OdaSayisi
        {
            get { return _odasayisi; }
            set { _odasayisi = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public bool KiralikMi
        {
            get { return _kiralikMi; }
            set { _kiralikMi = value; }
        }

        public override string ToString()
        {
            return _adres + "," + _odasayisi + "," + _fiyat;
        }
    }
}
