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

            PlayGame game = new PlayGame();
            PlayerSelection playerSelection = new PlayerSelection();

            Console.WriteLine("Please make a selection:");

            Selection p1Selection = playerSelection.UserSelection();
            Selection p2Selection = playerSelection.PcSelection();

            Console.WriteLine("You have chosen: " + p1Selection);
            Console.WriteLine("The pc chose: " + p2Selection);

            Outcome outcome = game.GameOutcome(p1Selection, p2Selection);

            Console.WriteLine("You:" + outcome);
            gameCounter.AddResult(outcome);
            Console.ReadLine();
        }
}

}
