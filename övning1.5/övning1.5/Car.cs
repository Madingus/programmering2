using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace övning1._5
{
    class Car
    {
        public enum VehicleType { Car, Motorcycle };

        private string regNr;
        private string mark;
        private string model;
        private VehicleType type;

        public Car(string _regNr, string _mark, string _model, VehicleType _type)
        {
            this.regNr = _regNr;
            this.mark = _mark;
            this.model = _model;
            this.type = _type;

        }

        public static bool CheckPlate(string plate)
        {
            Regex regex = new Regex("^[A-Z]{3}[0-9]{3}$");
            Regex regexNew = new Regex("^[A-Z]{3}[0-9]{2}[A-Z]{1}$");

            if (!Regex.IsMatch(plate, regex.ToString()) && !Regex.IsMatch(plate, regexNew.ToString()))
            {
                return false;
            }

            return true;
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

        public VehicleType Type
        {
            get { return type; }
        }

        public override string ToString()
        {
            return this.Type + ": " + this.regNr + " " + this.mark + " " + this.model;
        }

    }
}
