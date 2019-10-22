using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Film : Ljudspår
    {

        
        protected string upplösning;

        public Film(string titel, int _speltid, string _upplösning): base(titel, _speltid)
        {
            
            this.upplösning = _upplösning;

        }


        public override string ToString()
        {
            return this.titel + ": " + this.speltid + " Minuter";
        }


    }
}
