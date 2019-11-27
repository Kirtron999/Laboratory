using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class TestInInterval : TestDescription
    {
        public Range1Interval standardResult;
        public TestInInterval(string name, Importance category, Range1Interval testRange, string unitName, string symbol)
            :base(name, category, unitName, symbol)
        {
            this.standardResult = testRange;
        }
        public override bool InRange(double value)
        {
            if (standardResult.Min <= value && value <= standardResult.Max)
                return true;
            else
                return false;
        }
    }
}
