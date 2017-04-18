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
            string selection = Console.ReadLine().ToLower();

            switch (selection[0])
            {
                //Erm not sure about the case selects.
                case 'n':
                    return Selection.Ninja;
                case 'p':
                    return Selection.Pirate;
                case 'v':
                    return Selection.Viking;
                case 'e':
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