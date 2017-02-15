using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPirateViking;

namespace VikingsPiratesNinjasTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            //test both players have vikings = tie
            Program.PlayGame();
            Assert.AreEqual(1,Program.Tie);
        }
    }
}
