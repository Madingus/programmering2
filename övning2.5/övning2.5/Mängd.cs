using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning2._5
{
    class Mängd<T>:Samling<T> // som samlingsklassen men den kan inte ta emot samma värde 2 gånger
    {
        public override void LäggTill(T e)
        {
           if(this.Har(e)==true )
            {
                MessageBox.Show("värdet finns redan!");
            }
            else
            {
                MessageBox.Show("funkar");
                base.LäggTill(e);           
            }
        }

    }
}
