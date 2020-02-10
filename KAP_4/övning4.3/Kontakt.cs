using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning4._3
{
    class Kontakt
    {
        string förnamn;
        string efternamn;
        string epost;
        string telefonnummer;


        public Kontakt(string _förnamn, string _efternamn, string _epost, int telefonnummer )
        {
            this.förnamn = _förnamn;
            this.efternamn = _efternamn;
            this.epost = _epost;
            this.telefonnummer = telefonnummer.ToString();
        }                               
                                        
        public int Telefonnummer           
        {                               
            get { return int.Parse(telefonnummer); }  
        }

        public string Förnamn
        {
            get { return förnamn; }
        }

        public string Efternamn
        {
            get { return efternamn; } 
        }

        public string Epost
        {
            get { return epost; }
        }
        


         public override string ToString()
        {
            return "tom string";
        }



    }
}
