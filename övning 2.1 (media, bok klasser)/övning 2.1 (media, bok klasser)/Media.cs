using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1__media__bok_klasser_
{
    class Media
    {
        protected string titel;


        public Media (string _titel)
        {
            this.titel = _titel;
        }

        public string Titel
        {
            get { return titel; }
        }


        public override string ToString()
        {
            return this.titel;
        }



    }
}
