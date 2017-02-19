using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        public static int numberOfWins;
        public static int numberOfLosses;
        public static int numberOfTies;

        public int Win(string outcome)
        {
            numberOfWins = numberOfWins + 1;
            Console.Out.WriteLine("numberOfWins: " + numberOfWins);
            return numberOfWins;
        }

        public int Loss(string outcome)
        {
            numberOfLosses = numberOfLosses + 1;
            Console.Out.WriteLine("numberOfLosses: " + numberOfLosses);
            return numberOfLosses;
        }

        public int Tie(string outcome)
        {
            numberOfTies = numberOfTies + 1;
            Console.Out.WriteLine("numberOfTies: " + numberOfTies);
            return numberOfTies;
        }
    }
}
