using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Kontorist : Anställd
    {

        private int månadslön;
        

        private Kontorist(int _månadslön, string namn) : base(namn)
        {


            this.månadslön = _månadslön;
            this.namn = namn;



        }


        public override string ToString()
        {
            return " " + månadslön;
        }

    }
}
