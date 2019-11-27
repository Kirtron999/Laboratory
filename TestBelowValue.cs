using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class TestBelowValue : TestDescription
    {
        public Range1Value standardResult;
        public TestBelowValue(string name, Importance category, Range1Value testRange, string unitName, string symbol)
            :base(name, category, unitName, symbol)
        {
            this.standardResult = testRange;
        }
        public override bool InRange(double value)
        {
            if (value < standardResult.Value)
                return true;
            else
                return false;
        }
    }
}
