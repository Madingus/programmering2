using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning2._5
{
    class Samling<T>
    {
        protected int buffert; //storlek på buffert
        protected T[] lista; //samling av element av vilken typ som helst
        protected int längd; //antal tillängliga platser
        protected int antal; //antal använda platser

        public Samling()
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expandera ( int storlek )
        {
            if (storlek < 1) return; // ???????

            // gör ett nytt större fält
            T[] temp = new T[längd + storlek];

            //kopiera värden från det gamla fältet
            for (int i = 0; i < antal; i++) temp[i] = lista[i];

            lista = temp;
            längd += storlek;

        }
        protected void Reducera()
        {
            //gör en ny mindre lsita
            T[] temp = new T[antal];

            //kopiera över värden från det gamla fältet
            for (int i = 0; i < antal; i++) temp[i] = lista[i];

            lista = temp;
            längd = antal;

        }

        public void LäggTill(T e)
        {
            //skaffa fler platser om det behövs
            if (antal + 1 > längd) Expandera(1 + buffert);

            lista[antal++] = e;

        }
        public T TaBort(int index)
        {
            T temp = lista[index];

            //flytta alla element efter index ett steg åt vänster
            for(int i = index; i <antal-1; i++)
            {
                lista[i] = lista[i + 1];
            }

            antal--;

            //krymp fältet om det finns tomma platser
            if (längd - antal > buffert) Reducera();

            return temp;


        }


    }
}
