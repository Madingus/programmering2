using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1__media__bok_klasser_
{
    class Ljudspår:Media
    {
        protected double speltid;

        public Ljudspår(double _speltid, string titel) : base(titel)
        {
            this.speltid = _speltid;
            this.titel = titel;

        }

        public double Speltid
        {
            get { return speltid; }
        }

        public override string ToString()
        {
            return titel + ": " + speltid + " minuter";
        }


    }
}
