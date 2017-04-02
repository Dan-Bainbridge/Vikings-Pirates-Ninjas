using System;

namespace VikingsPiratesNinjas
{
    public enum Outcome
    {
        Drew,
        Won,
        Lost
    }

    public enum Selection
    {
        Viking,
        Ninja,
        Pirate,
        Exit
    }
    public class PlayGame
    {
        public const string Viking = "Viking";
        public const string Ninja = "Ninja";
        public const string Pirate = "Pirate";
        public const string Exit = "Exit";

        public Selection PlayerSelection()
        {
            string selection = Console.ReadLine();

            switch (selection)
            {
                //Erm not sure about the case selects.
                case Ninja:
                    return Selection.Ninja;
                case "n":
                    return Selection.Ninja;
                case Pirate:
                    return Selection.Pirate;
                case "p":
                    return Selection.Pirate;
                case Viking:
                    return Selection.Viking;
                case "v":
                    return Selection.Viking;
                case "e":
                    return Selection.Exit;
                case Exit:
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
        public Outcome GameOutcome(Selection p1Selection, Selection p2Selection)
        {

            if (p1Selection == p2Selection)
            {
                return Outcome.Drew;
            }
            if (p1Selection == Selection.Ninja && p2Selection == Selection.Viking ||
                p1Selection == Selection.Viking && p2Selection == Selection.Pirate ||
                p1Selection == Selection.Pirate && p2Selection == Selection.Ninja)
            {
                return Outcome.Won;
            }
            return Outcome.Lost;
        }
    }
}
