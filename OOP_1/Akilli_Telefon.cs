using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Akilli_Telefon : Telefon
    {
        // iki sınıfta ortak olanlar için farklı bir sınıf oluşturduk.
        //private string _marka;
        //private string _model;
        //private double _fiyat;
        private bool _kablosuzSarj;
        private double _ekranBoyutu;
        private string _islemciMarka;
        private string _islemciModeli;

        public bool KablosuzSarj
        {
            get { return _kablosuzSarj; }
            set { _kablosuzSarj = value; }

        }
        public double EkranBoyutu
        {
            get { return _ekranBoyutu; }
            set { _ekranBoyutu = value; }

        }
        public string IslemciMarka
        {
            get { return _islemciMarka; }
            set { _islemciMarka = value; }

        }
        public string IslemciModeli
        {
            get { return _islemciModeli; }
            set { _islemciModeli = value; }

        }
    }
}
