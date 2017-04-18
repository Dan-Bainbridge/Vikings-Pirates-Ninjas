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
            Game game = new Game();

            var result = game.Play(Selection.Pirate, Selection.Pirate);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveNinja()
        {
            Game game = new Game();

            var result = game.Play(Selection.Ninja, Selection.Ninja);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForTieWhenBothPlayersHaveVikings()
        {
            Game game = new Game();

            var result = game.Play(Selection.Viking, Selection.Viking);
            Assert.AreEqual(Outcome.Drew, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserVikingPlaysPcPirate()
        {
            Game game = new Game();

            var result = game.Play(Selection.Viking, Selection.Pirate);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserPiratePlaysPcNinja()
        {
            Game game = new Game();

            var result = game.Play(Selection.Pirate, Selection.Ninja);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserWinWhenUserNinjaPlaysPcViking()
        {
            Game game = new Game();

            var result = game.Play(Selection.Ninja, Selection.Viking);
            Assert.AreEqual(Outcome.Won, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserPiratePlaysPcViking()
        {
            Game game = new Game();

            var result = game.Play(Selection.Pirate, Selection.Viking);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserNinjaPlaysPcPirate()
        {
            Game game = new Game();

            var result = game.Play(Selection.Ninja, Selection.Pirate);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [TestMethod]
        public void TestForUserLossWhenUserVikingPlaysPcNinja()
        {
            Game game = new Game();

            var result = game.Play(Selection.Viking, Selection.Ninja);
            Assert.AreEqual(Outcome.Lost, result);
        }
    }
}
