using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning1._5
{
    class Car
    {

        private string regNr;
        private string mark;
        private string model;
        private string type;

        public Car(string _regNr, string _mark, string _model, string _type)
        {
            this.regNr = _regNr;
            this.mark = _mark;
            this.model = _model;
            this.type = _type;

        }

        public string RegNr
        {
            get { return regNr;  }
        }

        public string Mark
        {
            get { return mark; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Type
        {
            get { return type; }
        }

        public override string ToString()
        {
            return this.regNr + " " + this.mark + " " + this.model;
        }

    }
}
