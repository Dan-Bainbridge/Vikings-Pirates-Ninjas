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

            game.GameOutcome("Pirate", "Pirate");
            Assert.AreEqual("Tie", game.GameOutcome.Outcome);
        }

        /*[TestMethod]
        public void TestForTieWhenBothPlayersHaveNinja()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Ninja", "Ninja");
            Assert.AreEqual("Tie", game.Outcome);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Viking", "Viking");
            Assert.AreEqual("Tie", game.Outcome);
        }

        [TestMethod]
        public void TestForUserWinWhenUserVikingPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Viking", "Pirate");
            Assert.AreEqual("Win", game.Outcome);
        }

        [TestMethod]
        public void TestForUserWinWhenUserPiratePlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Pirate", "Ninja");
            Assert.AreEqual("Win", game.Outcome);
        }

        [TestMethod]
        public void TestForUserWinWhenUserNinjaPlaysPcViking()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Ninja", "Viking");
            Assert.AreEqual("Win", game.Outcome);
        }

        [TestMethod]
        public void TestForUserLossWhenUserPiratePlaysPcViking()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Pirate", "Viking");
            Assert.AreEqual("Loss", game.Outcome);
        }

        [TestMethod]
        public void TestForUserLossWhenUserNinjaPlaysPcPirate()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Ninja", "Pirate");
            Assert.AreEqual("Loss", game.Outcome);
        }

        [TestMethod]
        public void TestForUserLossWhenUserVikingPlaysPcNinja()
        {
            PlayGame game = new PlayGame();

            game.GameOutcome("Viking", "Ninja");
            Assert.AreEqual("Loss", game.Outcome);
        }*/
    }
}
