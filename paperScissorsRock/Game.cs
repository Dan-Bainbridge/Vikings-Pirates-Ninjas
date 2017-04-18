using System;

namespace VikingsPiratesNinjas
{
    public enum Outcome
    {
        Drew,
        Won,
        Lost
    }

    public class PlayGame
    {
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
