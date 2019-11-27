using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class TestIn2Intervals : TestDescription
    {
        public Range2Intervals standardResult;
        public TestIn2Intervals(string name, Importance category, Range2Intervals testRange, string unitName, string symbol)
            :base(name, category, unitName, symbol)
        {
            this.standardResult = testRange;
        }
        public override bool InRange(double value)
        {
            if ((standardResult.Min1 <= value && value <= standardResult.Max1) || (standardResult.Min2 <= value && value <= standardResult.Max2))
                return true;
            else
                return false;
        }
    }
}
