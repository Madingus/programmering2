using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Säljare : Anställd
    {

        private double provision;
        private double försäljning;
        /* private string säljare (n :strnig, p :double, f :double)??? */
        
        public Säljare(double _provision, double _försäljning, string namn) : base(namn)
        {

            this.provision = _provision;
            this.försäljning = _försäljning;
            this.namn = namn;





        }

        public override string ToString()
        {
            return this.namn + " (säljare)";
        }

    }
}
