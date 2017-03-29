using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        private int _numberOfLosses;
        private int _numberOfTies;

        public int NumberOfWons { get; private set; }

        public void AddResult(Outcome outcome)
        {
            switch (outcome)
            {
                case Outcome.Won:
                    NumberOfWons++;
                    break;
                case Outcome.Drew:
                    _numberOfTies = _numberOfTies + 1;
                    break;
                case Outcome.Lost:
                    _numberOfLosses = _numberOfLosses + 1;
                    break;
            }
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
