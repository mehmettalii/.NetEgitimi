using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Cep_Telefonu : Telefon
    {
        // iki sınıfta ortak olanlar için farklı bir sınıf oluşturduk. Oradan ": Telefon" ile miras aldık. Sadece bir yerden miras alabiliriz.
        //private string _marka;
        //private string _model;
        //private double _fiyat;
        private bool _kameraVarMi;
        private bool _kizilOtesiVarMi;

        public bool KameraVarMi
        {
            get { return _kameraVarMi; }
            set { _kameraVarMi = value; }

        }
        public bool kizilOtesiVarMi
        {
            get { return _kizilOtesiVarMi; }
            set { _kizilOtesiVarMi = value; }

        }
    }
}
