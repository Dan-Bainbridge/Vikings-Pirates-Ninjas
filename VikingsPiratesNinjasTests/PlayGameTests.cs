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

            var result = game.GameOutcome(PlayGame.Pirate, PlayGame.Pirate);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Ninja, PlayGame.Ninja);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Viking, PlayGame.Viking);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserVikingPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Viking, PlayGame.Pirate);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserPiratePlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Pirate, PlayGame.Ninja);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserNinjaPlaysPcViking()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Ninja, PlayGame.Viking);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserPiratePlaysPcViking()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Pirate, PlayGame.Viking);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserNinjaPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Ninja, PlayGame.Pirate);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserVikingPlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            var result = game.GameOutcome(PlayGame.Viking, PlayGame.Ninja);
            Assert.AreEqual(Outcome.Lost, result);
        }
    }
}
