using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public abstract class TestDescription
    {

        public string Name;
        public Importance Category;
        public Unit Measure;

        public TestDescription(string name, Importance category, string unitName, string symbol)
        {
            this.Name = name;
            this.Category = category;
            //this.standardResult = testRange;
            this.Measure = new Unit(unitName, symbol);

        }

        public abstract bool InRange(double value);
    }
}
