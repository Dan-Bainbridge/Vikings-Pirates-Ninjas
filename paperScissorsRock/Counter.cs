using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        public int NumberOfWins { get; private set; }
        public int NumberOfLosses { get; private set; }
        public int NumberOfTies { get; private set; }


        public void AddResult(Outcome outcome)
        {
            switch (outcome)
            {
                case Outcome.Won:
                    NumberOfWins++;
                    break;
                case Outcome.Drew:
                    NumberOfTies++;
                    break;
                case Outcome.Lost:
                    NumberOfLosses++;
                    break;
            }
        }
    }
}
