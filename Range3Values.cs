using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Range3Values
    {
        private readonly double _value1;
        private readonly double _value2;
        private readonly double _value3;

        public double Value1
        {
            get { return _value1; }
        }

        public double Value2
        {
            get { return _value2; }
        }

        public double Value3
        {
            get { return _value3; }
        }

        public Range3Values(double value1, double value2, double value3)
        {
            this._value1 = value1;
            this._value2 = value2;
            this._value3 = value3;
        }
    }
}
