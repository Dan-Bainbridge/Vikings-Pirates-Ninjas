using System;
using System.Security.Cryptography.X509Certificates;

namespace VikingsPiratesNinjas
{

    public class Program
    {
        static void Main(string[] args)
        {
            Counter gameCounter = new Counter();
            Console.WriteLine("Please enter Viking(v)/Ninja(n)/Pirate(p) or Exit \r\n");

            string selection;
            do
            {
                PlayGame game = new PlayGame();

                Console.WriteLine("Please make a selection:");

                var userSelection = game.UserSelection();
                selection = userSelection;
                if (selection.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("You have chosen: " + userSelection);
                var pcSelection = game.PcSelection();
                Console.WriteLine("The pc chose: " + pcSelection);
                string outcome = game.GameOutcome(userSelection, pcSelection);

                gameCounter.AddResult(outcome);

                Console.WriteLine("You " + outcome);
            } while (selection != "exit");
        }
    }
}
