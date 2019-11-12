using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Bok  : Media
    {

        
        protected int antalSidor;

        public Bok(string titel, int antalSidor) : base(titel)
        {
            this.antalSidor = antalSidor;

        }

        public override string ToString()
        {
            return this.titel + ": " + this.antalSidor + " Sidor"; 
        }




    }
}
