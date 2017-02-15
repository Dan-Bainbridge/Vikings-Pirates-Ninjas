using System;

namespace NinjaPirateViking
{
    public class Program
    {
        //Global variables defaulted to a valid selection for user and pc.
        private static string userSelection = "Viking";
        private static string pcSelection = "Viking";
        
        //Global variables for keeping score of games
        public static int Tie = 0;
        private static int Win = 0;
        private static int Total = 0;
        private static int Loss = 0;

        static void Main(string[] args)
        {
            /*Put instructions here!! Also I'm checking if this is the syntactically correct way 
             * of doing multi line comments and it is, whoop. Some comments below this use // 
             * because I didn't know if it would work and I was scared so I played safe. 
             * But now I'm getting cocky as my game works and shit 
             * and I am a master coder RAWRAWRAWRAWRAWRAWR*/

            //DO While loop, asks users if they want to play again after each turn.
            do
            {
                //Get User input
                UserSelection();
                //Generate pc input
                PcSelection();
                //work out who won
                PlayGame();
                //ask user if they want to play again
                Console.WriteLine("Would you like to play again y/n");
              //detect y to play again, anything else quits out           
            } while (Console.ReadLine() == "y");
        }

        public static void PlayGame()
        {
            //Evaluate Who Won
            //If the two selections are equal its a draw, thus increment the relevant counters
            if (userSelection == pcSelection)
            {
                Tie = Tie + 1;
                Total = Total + 1;
            }
            //These are three win scenarios for user. Must be a way to make this look better, 
            //but I don't know what it is.
            else if (userSelection == "Ninja" && pcSelection == "Viking" ||
                     userSelection == "Viking" && pcSelection == "Pirate" ||
                     userSelection == "Pirate" && pcSelection == "Ninja")
            {
                Win = Win + 1;
                Total = Total + 1;
            }
            //These are the loss scenarios. In theory this could just be else as we have tie and
            //win covered, but better to explicity say. Unless it isn't then we can change this.
            else if (pcSelection == "Ninja" && userSelection == "Viking" ||
                     pcSelection == "Viking" && userSelection == "Pirate" ||
                     pcSelection == "Pirate" && userSelection == "Ninja")
            {
                Loss = Loss + 1;
                Total = Total + 1;
            }

            OutputResult();
        }

        private static void OutputResult()
        {
            //Output the result each time, in it's own method????
            Console.WriteLine("Wins: " + Win);
            Console.WriteLine("Ties: " + Tie);
            Console.WriteLine("Losses: " + Loss);
            Console.WriteLine("Total: " + Total);
        }

        private static void UserSelection()
        {
            //Tell user what to put in, read the key.
            Console.WriteLine("Please select Viking|Ninja|Pirate");
            string selection = Console.ReadLine();

            //Case select for user inputs. Sets the user input or errors out, sort of.
            switch (selection)
            {
                case "Ninja":
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "n":
                    selection = "Ninja";
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "Pirate":
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "p":
                    selection = "Pirate";
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "Viking":
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                case "vpy" +
                     "ypy" +
                     "":
                    selection = "Viking";
                    Console.WriteLine("You have chosen: " + selection);
                    break;
                default:
                    Console.WriteLine("Invalid Selection, selections are case sensitive");
                    break;
                    
            }
            userSelection = selection;
        }

        private static void PcSelection()
        {
            //Make PC Select Viking/Ninja/Pirate
            //pick a random number between 1 and 3
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            //defaultthe selection to Viking, obvs.
            string selection = "Viking";

            //choose a "weapon" depending on the random number above
            switch (choice)
            {
                case 1:
                    selection = "Pirate";
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                case 2:
                    selection = "Ninja";
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                case 3:
                    selection = "Viking";
                    Console.WriteLine("I have chosen: " + selection);
                    break;
                default:
                    Console.WriteLine("Something has gone wrong");
                    break;
            }
            pcSelection = selection;
        }
    }
}
