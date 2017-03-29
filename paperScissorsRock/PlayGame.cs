using System;

namespace VikingsPiratesNinjas
{
    public class PlayGame
    {
        public const string Viking = "Viking";
        public const string Ninja = "Ninja";
        public const string Pirate = "Pirate";
        public const string Exit = "Exit";

        public string UserSelection()
        {
            string selection = Console.ReadLine();

            switch (selection)
            {
                case Ninja:
                    break;
                case "n":
                    selection = Ninja;
                    break;
                case Pirate:
                    break;
                case "p":
                    selection = Pirate;
                    break;
                case Viking:
                    break;
                case "v":
                    selection = Viking;
                    break;
                case "e":
                    selection = Exit;
                    break;
                case Exit:
                    selection = Exit;
                    break;
                default:
                    break;

            }
            return selection;
        }

        public string PcSelection()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            string selection = Viking;

            switch (choice)
            {
                case 1:
                    selection = Pirate;
                    break;
                case 2:
                    selection = Ninja;
                    break;
                case 3:
                    selection = Viking;
                    break;
                default:
                    break;
            }
            return selection;
        }
        public Outcome GameOutcome(string userSelection, string pcSelection)
        {

            if (userSelection == pcSelection)
            {
                return Outcome.Drew;
            }
            if (userSelection == Ninja && pcSelection == Viking ||
                userSelection == Viking && pcSelection == Pirate ||
                userSelection == Pirate && pcSelection == Ninja)
            {
                return Outcome.Won;
            }
            return Outcome.Lost;
        }
    }
}
