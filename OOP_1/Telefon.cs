using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Telefon
    {
        private string _marka;
        private string _model;
        private double _fiyat;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }

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
    }
}
