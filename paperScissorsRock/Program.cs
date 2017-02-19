using System;

namespace VikingsPiratesNinjas
{
    public class Program
    {
        static void Main(string[] args)
        {
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
            CheckResult(outcome);
            exit = Console.ReadLine();
            } while (exit != "exit");
        }


        private static void GetUserInput()
        {
            
        }
        private static void CheckResult(string outcome)
        {
            var counter = new Counter();
            switch (outcome)
            {
                case "Win":
                    counter.Win(outcome);

                    break;
                case "Loss":
                    counter.Loss(outcome);
                    break;
                case "Tie":
                    counter.Tie(outcome);
                    break;
            }
        }
    }
}
