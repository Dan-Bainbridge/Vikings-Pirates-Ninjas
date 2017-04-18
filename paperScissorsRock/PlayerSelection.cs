using System;

namespace VikingsPiratesNinjas
{
    public enum Selection
    {
        Viking,
        Ninja,
        Pirate,
        Exit
    }

    public class PlayerSelection
    {
        public Selection UserSelection()
        {
            string selection = Console.ReadLine();

            switch (selection)
            {
                //Erm not sure about the case selects.
                case "Ninja":
                    return Selection.Ninja;
                case "n":
                    return Selection.Ninja;
                case "Pirate":
                    return Selection.Pirate;
                case "p":
                    return Selection.Pirate;
                case "Viking":
                    return Selection.Viking;
                case "v":
                    return Selection.Viking;
                case "e":
                    return Selection.Exit;
                case "Exit":
                    return Selection.Exit;
                default:
                    return Selection.Viking;
            }
        }

        public Selection PcSelection()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            switch (choice)
            {
                case 1:
                    return Selection.Pirate;
                case 2:
                    return Selection.Ninja;
                case 3:
                    return Selection.Viking;
                default:
                    return Selection.Viking;
            }
        }
    }
}