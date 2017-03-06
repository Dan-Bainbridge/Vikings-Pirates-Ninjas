using System;

namespace VikingsPiratesNinjas
{
    public class Input
    {
        public const string Viking = "Viking";
        public const string Ninja = "Ninja";
        public const string Pirate = "Pirate";

        public string UserSelection()
        {
            //Tell user what to put in, read the key.
            Console.WriteLine("Please select Viking|Ninja|Pirate");
            string selection = Console.ReadLine();

            //Case select for user inputs. Sets the user input or errors out, sort of.
            switch (selection)
            {
                case Ninja:
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "n":
                    selection = Ninja;
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case Pirate:
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "p":
                    selection = Pirate;
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case Viking:
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "v":
                    selection = Viking;
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                default:
                    Console.WriteLine("Invalid Selection, selections are case sensitive");
                    break;

            }
            return selection;
        }

        public string PcSelection()
        {
            //Make PC Select Viking/Ninja/Pirate
            //pick a random number between 1 and 3
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            //defaultthe selection to Viking, obvs.
            string selection = Viking;

            //choose a "weapon" depending on the random number above
            switch (choice)
            {
                case 1:
                    selection = Pirate;
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                case 2:
                    selection = Ninja;
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                case 3:
                    selection = Viking;
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                default:
                    Console.WriteLine("Something has gone wrong");
                    break;
            }
            return selection;
        }
    }
}
