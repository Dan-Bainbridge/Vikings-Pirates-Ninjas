using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VikingsPiratesNinjas;

namespace VikingsPiratesNinjasTests
{
    [TestClass]
    public class PlayGameTests
    {
        [TestMethod]
        public void TestForTieWhenBothPlayersHavePirate()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Pirate, Selection.Pirate);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Ninja, Selection.Ninja);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Viking, Selection.Viking);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserVikingPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Viking, Selection.Pirate);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserPiratePlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Pirate, Selection.Ninja);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserNinjaPlaysPcViking()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Ninja, Selection.Viking);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserPiratePlaysPcViking()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Pirate, Selection.Viking);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserNinjaPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Ninja, Selection.Pirate);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserVikingPlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(Selection.Viking, Selection.Ninja);
            Assert.AreEqual(Outcome.Lost, result);
        }
    }
}
