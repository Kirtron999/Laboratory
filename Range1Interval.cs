using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Range1Interval
    {
        private readonly double _min;
        private readonly double _max;

        public double Min
        {
            get { return _min; }
        }

        public double Max
        {
            get { return _max; }
        }

        public Range1Interval(double min, double max)
        {
            if (min > max)
            {
                this._min = max;
                this._max = min;
            }
            else
            {
                this._min = min;
                this._max = max;
            }
        }
    }
}
