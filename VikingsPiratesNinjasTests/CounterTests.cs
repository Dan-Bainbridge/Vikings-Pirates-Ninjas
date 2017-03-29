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
            Assert.AreEqual(1, gameCounter.NumberOfWons);
            Assert.AreEqual(0, gameCounter.GetDraws());
            Assert.AreEqual(0, gameCounter.GetLoss());
        }

        [TestMethod]
        public void TestForNumberOfDrawsIncreasingWithDrawOutcome()
        {
            Counter gameCounter = new Counter();

            gameCounter.AddResult(Outcome.Drew);
            Assert.AreEqual(1, gameCounter.GetDraws());
        }
    }
}
