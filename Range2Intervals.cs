using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Range2Intervals
    {
        private readonly double _min1;
        private readonly double _max1;

        private readonly double _min2;
        private readonly double _max2;

        public double Min1
        {
            get { return _min1; }
        }

        public double Max1
        {
            get { return _max1; }
        }

        public double Min2
        {
            get { return _min2; }
        }

        public double Max2
        {
            get { return _max2; }
        }

        public Range2Intervals(double min1, double max1, double min2, double max2)
        {
            if (min1 > max1)
            {
                this._min1 = max1;
                this._max1 = min1;
            }
            else
            {
                this._min1 = min1;
                this._max1 = max1;
            }


            if (min2 > max2)
            {
                this._min2 = max2;
                this._max2 = min2;
            }
            else
            {
                this._min2 = min2;
                this._max2 = max2;
            }
        }
    }
}
