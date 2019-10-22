using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Ljudspår : Media
    {
        protected int speltid;
        
        public Ljudspår(string titel, int _speltid) : base(titel)
        {

            this.speltid = _speltid;

        }

        public override string ToString()
        {
            return this.titel + ": " + this.speltid + " Minuter";
        }


    }
}
