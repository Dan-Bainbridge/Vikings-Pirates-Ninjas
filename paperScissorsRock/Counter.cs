using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsPiratesNinjas
{
    public class Counter
    {
        private int _numberOfWons;
        private int _numberOfLostes;
        private int _numberOfTies;

        public int Won(string outcome)
        {
            _numberOfWons = _numberOfWons + 1;
            return _numberOfWons;
        }

        public int Lost(string outcome)
        {
            _numberOfLostes = _numberOfLostes + 1;
            return _numberOfLostes;
        }

        public int Tie(string outcome)
        {
            _numberOfTies = _numberOfTies + 1;
            return _numberOfTies;
        }
    }
}
