using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        private int _numberOfWons;
        private int _numberOfLosses;
        private int _numberOfTies;

        public void AddResult(Outcome outcome)
        {
            switch (outcome)
            {
                case Outcome.Won:
                    _numberOfWons++;
                    break;
                case Outcome.Drew:
                    _numberOfTies = _numberOfTies + 1;
                    break;
                case Outcome.Lost:
                    _numberOfLosses = _numberOfLosses + 1;
                    break;
            }
        }

        public int GetWins()
        {
            return _numberOfWons;
        }

        public int GetDraws()
        {
            return _numberOfTies;
        }

        public int GetLoss()
        {
            return _numberOfLosses;
        }
    }
}
