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

            Console.WriteLine("Please press 1 for 1 player or 2 for 2 player");
            string player2 = Console.ReadLine();

            if (player2 == "2")
            {
                TwoHumanGame(playerSelection, game, gameCounter);
            }
            else if (player2 == "1")
            {
                HumanVCPUGame(playerSelection, game, gameCounter);
            }
            else
            {
                Console.WriteLine("Didn't choose 1 or 2");
            }
        }

        private static void TwoHumanGame(PlayerSelection playerSelection, PlayGame game, Counter gameCounter)
        {
            while (true)
            {

                Console.WriteLine("Player 1 Please make a selection:");
                var p1Selection = playerSelection.UserSelection();
                if (p1Selection == Selection.Exit)
                    break;

                Console.WriteLine("Player 2 Please make a selection:");
                var p2Selection = playerSelection.UserSelection();
                if (p2Selection == Selection.Exit)
                    break;

                Console.WriteLine("Player 1 chose: " + p1Selection);
                Console.WriteLine("Player 2 chose: " + p2Selection);
                
                var outcome = game.GameOutcome(p1Selection, p2Selection);
                gameCounter.AddResult(outcome);

                if (gameCounter.NumberOfWins > gameCounter.NumberOfLosses)
                {
                    Console.WriteLine("Player 1 Wins");
                }
                else if (gameCounter.NumberOfLosses > gameCounter.NumberOfWins)
                {
                    Console.WriteLine("Player 2 Wins");
                }
                else
                {
                    Console.WriteLine("It was a draw!");
                }
               
            }

            if (gameCounter.NumberOfWins > gameCounter.NumberOfLosses)
            {
                Console.WriteLine("Player 1 destroyed player 2!");
            }
            else if (gameCounter.NumberOfLosses > gameCounter.NumberOfWins)
            {
                Console.WriteLine("Player 2 destroyed player 1!");
            }
            else
            {
                Console.WriteLine("Noone wins - It was a draw!");
            }
            Console.ReadLine();
        }

        private static void HumanVCPUGame(PlayerSelection playerSelection, PlayGame game, Counter gameCounter)
        {
            Console.WriteLine("Please make a selection:");

            Selection p1Selection = playerSelection.UserSelection();
            Selection p2Selection = playerSelection.PcSelection();

            Console.WriteLine("Player 1 chose: " + p1Selection);
            Console.WriteLine("Player 2 chose: " + p2Selection);

            Outcome outcome = game.GameOutcome(p1Selection, p2Selection);

            Console.WriteLine("You:" + outcome);
            gameCounter.AddResult(outcome);
        }
    }

}
