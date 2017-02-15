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

            Program.PlayGame(Program.Pirate, Program.Pirate);
            Assert.AreEqual(tiesBefore + 1, Program.Tie);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveNinjas()
        {
            var tiesBefore = Program.Tie;

            Program.PlayGame(Program.Ninja, Program.Ninja);
            Assert.AreEqual(tiesBefore + 1, Program.Tie);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            var tiesBefore = Program.Tie;

            Program.PlayGame(Program.Viking, Program.Viking);
            Assert.AreEqual(tiesBefore + 1,Program.Tie);
        }

        [TestMethod]
        public void TestForUserWinWhenUserVikingPlaysPcPirate()
        {
            var winsBefore = Program.Win;

            Program.PlayGame(Program.Viking, Program.Pirate);
            Assert.AreEqual(winsBefore + 1, Program.Win);
        }

        [TestMethod]
        public void TestForUserWinWhenUserPiratePlaysPcNinja()
        {
            var winsBefore = Program.Win;

            Program.PlayGame(Program.Pirate, Program.Ninja);
            Assert.AreEqual(winsBefore + 1, Program.Win);
        }

        [TestMethod]
        public void TestForUserWinWhenUserNinjaPlaysPcViking()
        {
            var winsBefore = Program.Win;

            Program.PlayGame(Program.Ninja, Program.Viking);
            Assert.AreEqual(winsBefore + 1, Program.Win);
        }

        [TestMethod]
        public void TestForUserLossWhenUserPiratePlaysPcViking()
        {
            var lossBefore = Program.Loss;

            Program.PlayGame(Program.Pirate, Program.Viking);
            Assert.AreEqual(lossBefore + 1, Program.Loss);
        }

        [TestMethod]
        public void TestForUserLossWhenUserNinjaPlaysPcPirate()
        {
            var lossBefore = Program.Loss;

            Program.PlayGame(Program.Ninja, Program.Pirate);
            Assert.AreEqual(lossBefore + 1, Program.Loss);
        }

        [TestMethod]
        public void TestForUserLossWhenUserVikingPlaysPcNinja()
        {
            var lossBefore = Program.Loss;

            Program.PlayGame(Program.Viking, Program.Ninja);
            Assert.AreEqual(lossBefore + 1, Program.Loss);
        }

    }
}
