using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Bilgisayar
    {
        private string _marka;
        private string _model;
        private double _fiyat;
        private int _ram;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }

            //değer atarken koşul koymak istersek

            /*
            
            set {
                if (value.Length<3)
                {
                    throw new Exception("Marka değeri 3 karakterden az olamaz");
                }
                
                _marka = value;}
            */
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        // get only özelliği olsun istiyorsak. bir şey setlenebilsin istemiyorsak
        public double KDVliFiyat
        {
            get { return _fiyat * 1.18; }
        }

        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        // form'da bilgisayarı yazdırdığımızda değerleri yazabilsin diye yaptık.
        public override string ToString()
        {
            return _marka + "," + _model;
        }
    }
}
