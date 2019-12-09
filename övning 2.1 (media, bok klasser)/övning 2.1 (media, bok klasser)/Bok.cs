using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1__media__bok_klasser_
{
    class Bok:Media
    {
        protected int antalSidor;

        public Bok(int _antalSidor, string titel):base(titel)
        {
            this.antalSidor = _antalSidor;
            this.titel = titel;
        }

        public int AntalSidor
        {
            get { return antalSidor; }
        }

        public override string ToString()
        {
            return titel + ": " + antalSidor + " sidor"; 
        }

    }
}
