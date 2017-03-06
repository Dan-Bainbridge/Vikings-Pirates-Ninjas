using System;
using System.Security.Cryptography.X509Certificates;

namespace VikingsPiratesNinjas
{

    public class Program
    {
        //This took me 45 fucking minutes, this better be right.
        private static Counter GameCounter;

        static void Main(string[] args)
        {
            //Had to do this so checkResult didn't need to be static. Totes confused.
            var newGame = new Program();
            GameCounter = new Counter();

            string exit;
            do
            {
            //Initiate Input Object
            var getInput = new Input();
            //Get User input    
            var input1 = getInput.UserSelection();
            //Generate pc input
            var input2 = getInput.PcSelection();

            ////Initiate PlayGame object
            var game = new PlayGame();
            var outcome = game.GameOutcome(input1, input2);

            newGame.CheckResult(outcome);
            exit = Console.ReadLine();
            } while (exit != "exit");
        }

        private void CheckResult(string outcome)
        {
            switch (outcome)
            {
                case "Win":
                    GameCounter.Win(outcome);
                    break;
                case "Loss":
                    GameCounter.Loss(outcome);
                    break;
                case "Tie":
                    GameCounter.Tie(outcome);
                    break;
            }
        }
    }
}
