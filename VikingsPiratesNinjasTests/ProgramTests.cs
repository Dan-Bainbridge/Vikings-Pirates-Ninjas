using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPirateViking;

namespace VikingsPiratesNinjasTests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void TestForTieWhenBothPlayersHavePirates()
        {
            var tiesBefore = Program.Tie;

            Program.PlayGame();
            Program.userSelection = "Pirates";
            Program.pcSelection = "Pirates";
            Assert.AreEqual(tiesBefore + 1, Program.Tie);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveNinjas()
        {
            var tiesBefore = Program.Tie;

            Program.PlayGame();
            Program.userSelection = "Ninjas";
            Program.pcSelection = "Ninjas";
            Assert.AreEqual(tiesBefore + 1, Program.Tie);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            var tiesBefore = Program.Tie;

            Assert.AreEqual("Viking", Program.userSelection);
            Assert.AreEqual("Viking", Program.pcSelection);

            Program.PlayGame();
            Assert.AreEqual(tiesBefore + 1,Program.Tie);
        }

    }
}
