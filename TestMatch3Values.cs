using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class TestMatch3Values : TestDescription
    {
        public Range3Values standardResult;
        public TestMatch3Values(string name, Importance category, Range3Values testRange, string unitName, string symbol)
            :base(name, category, unitName, symbol)
        {
            this.standardResult = testRange;
        }
        public override bool InRange(double value)
        {
            if (value == standardResult.Value1 || value == standardResult.Value2 || value == standardResult.Value3)
                return true;
            else
                return false;
        }
    }
}
