using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1__media__bok_klasser_
{
    class Film:Ljudspår
    {

        protected string upplösning;
        public Film(string _upplösning, string titel, double speltid):base(speltid,titel) //possible messup (swap places with speltid and titel)
        {
            this.titel = titel;
            this.speltid = speltid;
            this.upplösning = _upplösning;
        }


        public override string ToString()
        {
            return titel + ": " + speltid + " minuter" +  ", Upplösning: " + upplösning;
        }

    }
}
