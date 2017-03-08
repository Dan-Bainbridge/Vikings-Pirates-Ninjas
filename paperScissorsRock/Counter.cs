using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        private int NumberOfWins;
        private int NumberOfLosses;
        private int NumberOfTies;

        public int Win(string outcome)
        {
            NumberOfWins = NumberOfWins + 1;
            Console.Out.WriteLine("numberOfWins: " + NumberOfWins);
            return NumberOfWins;
        }

        public int Loss(string outcome)
        {
            NumberOfLosses = NumberOfLosses + 1;
            Console.Out.WriteLine("numberOfLosses: " + NumberOfLosses);
            return NumberOfLosses;
        }

        public int Tie(string outcome)
        {
            NumberOfTies = NumberOfTies + 1;
            Console.Out.WriteLine("numberOfTies: " + NumberOfTies);
            return NumberOfTies;
        }
    }
}
