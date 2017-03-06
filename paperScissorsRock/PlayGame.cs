using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class PlayGame
    {
        public static string outcome = "";

        //Should these variables be named the same? 
        //I think so and I don't see a good reason why not, but ........
        public string GameOutcome(string userSelection, string pcSelection)
        {
            //do the game logic
            if (userSelection == pcSelection)
            {
                //Add logic in the event of a Tie
                outcome = "Tie";
                return outcome;
            }
            else if (userSelection == "Ninja" && pcSelection == "Viking" ||
                     userSelection == "Viking" && pcSelection == "Pirate" ||
                     userSelection == "Pirate" && pcSelection == "Ninja")
            {
                //Add logic in the event of a Win
                outcome = "Win";
                return outcome;
            }
            else if (pcSelection == "Ninja" && userSelection == "Viking" ||
                     pcSelection == "Viking" && userSelection == "Pirate" ||
                     pcSelection == "Pirate" && userSelection == "Ninja")
            {
                //Add logic in the event of a Loss
                //Just return Loss?
                outcome = "Loss";
                return outcome;
            }
            return outcome;
        }
    }
}
