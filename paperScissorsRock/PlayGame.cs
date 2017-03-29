using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string selection = "viking";

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
        public string GameOutcome(string userSelection, string pcSelection)
        {
            var Outcome = "";

            if (userSelection == pcSelection)
            {
                Outcome = "Drew";
                return Outcome;
            }
            if (userSelection == "Ninja" && pcSelection == "Viking" ||
                userSelection == "Viking" && pcSelection == "Pirate" ||
                userSelection == "Pirate" && pcSelection == "Ninja")
            {
                Outcome = "Won";
                return Outcome;
            }
            if (pcSelection == "Ninja" && userSelection == "Viking" ||
                pcSelection == "Viking" && userSelection == "Pirate" ||
                pcSelection == "Pirate" && userSelection == "Ninja")
            {
                Outcome = "Lost";
                return Outcome;
            }
            return Outcome;
        }
    }
}
