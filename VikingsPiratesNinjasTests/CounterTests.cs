using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VikingsPiratesNinjas;

namespace VikingsPiratesNinjasTests
{
    [TestClass]
    public class CounterTests
    {
        [TestMethod]
        public void TestForNumberOfWinsIncreasingWithWinOutcome()
        {
            Counter gameCounter = new Counter();

            gameCounter.AddResult(Outcome.Won);
            Assert.AreEqual(1, gameCounter.NumberOfWins);
            Assert.AreEqual(0, gameCounter.NumberOfTies);
            Assert.AreEqual(0, gameCounter.NumberOfLosses);
        }

        [TestMethod]
        public void TestForNumberOfDrawsIncreasingWithDrawOutcome()
        {
            Counter gameCounter = new Counter();

            gameCounter.AddResult(Outcome.Drew);
            Assert.AreEqual(0, gameCounter.NumberOfWins);
            Assert.AreEqual(1, gameCounter.NumberOfTies);
            Assert.AreEqual(0, gameCounter.NumberOfLosses);
        }

        [TestMethod]
        public void TestForNumberOfLossesIncreasingWithWinOutcome()
        {
            Counter gameCounter = new Counter();

            gameCounter.AddResult(Outcome.Lost);
            Assert.AreEqual(0, gameCounter.NumberOfWins);
            Assert.AreEqual(0, gameCounter.NumberOfTies);
            Assert.AreEqual(1, gameCounter.NumberOfLosses);
        }
    }
}
