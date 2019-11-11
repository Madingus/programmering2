using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Konsult : Anställd
    {

        private double arbetadeTimmar;
        private double timLön;

        public Konsult(double _arbetadeTimmar, double _timLön, string namn) : base(namn)
        {
            this.arbetadeTimmar = _arbetadeTimmar;
            this.timLön = _timLön;
            this.namn = namn;

        }

        public override string ToString()
        {
            return this.namn + "(Konsult)";
        }

    }
}
