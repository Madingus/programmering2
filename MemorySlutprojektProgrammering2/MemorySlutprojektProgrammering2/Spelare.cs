using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorySlutprojektProgrammering2
{
    class Spelare
    {
        protected int score;
        protected int wins;
        protected bool myTurn = false;


       public Spelare(int _score, int _wins, bool _myTurn)
       {
            this.score = _score;
            this.wins = _wins;
            this.myTurn = _myTurn;

       }

        public int Score
        {
            get { return score; }
            set { score = value; }

        }
        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        public bool MyTurn
        {
            get { return myTurn; }
            set { myTurn = value; }
        }





    }
    


}
