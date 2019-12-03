using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1__media__bok_klasser_
{
    class Bok : Media
    {
        private string sidor;


        public Bok (string _sidor, string titel) : base(titel)
        {
            this.sidor = _sidor;
            this.titel = titel;
            
        }
        private string Sidor
        {
            get { return sidor; }
        }


    }
}
