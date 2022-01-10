using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Urun
    {
        private string _ad;  // Field
        private double _fiyat;
        private int _stokMiktari;
        private DateTime _sonKullanmaTarihi;
        private DateTime _uretimTarihi;

        // Encapsulation : Private olan properties public yapma
        public string Ad // Properties
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public double Fiyat // Properties
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public int StokMiktari // Properties
        {
            get { return _stokMiktari; }
            set { _stokMiktari = value; }
        }

        public DateTime UretimTarihi // Properties
        {
            get { return _uretimTarihi; }
            set { _uretimTarihi = value; }
        }

        public DateTime SonKullanmaTarihi // Properties
        {

            //DateTime besGunSonrakiTarih = DateTime.Now.AddDays(5);

            get { return _uretimTarihi.AddDays(30); }
        }

        public override string ToString()
        {
            return "Ad : " + _ad + " , " + "Fiyat : " + _fiyat + " , " + "Stok Miktarı : " + _stokMiktari + " , " + "U.T : " + _uretimTarihi + " , " + "S.K.T : " + _sonKullanmaTarihi;
        }
    }
}
