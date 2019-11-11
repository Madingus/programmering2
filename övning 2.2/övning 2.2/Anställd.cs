using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Anställd
    {
       
        protected string namn;
        


        public Anställd( string _namn)
        {
            
            this.namn = _namn;
           


        }
       

        public string Namn
        {
            get { return namn; }
        }

        public double BeräknaLön()
        {
            return 0;
        }



    }
}
