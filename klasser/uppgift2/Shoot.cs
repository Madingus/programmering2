using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift2
{
    class Shoot
    {



        string namn;
        int poäng;

        public static List<Shoot> shootList = new List<Shoot>();

        //Konstruktor
        public Shoot(string n, int p)
        {
            namn = n;
            poäng = p;

        }
        public override string ToString()
        {
            return namn + ": " + poäng + " poäng";
        }

        public int Poäng
        {
            get { return poäng; }

        }
    }
}
