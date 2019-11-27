using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Unit //done
    {
        private readonly String _name;
        private readonly String _symbol;

        public String Name
        {
            get { return _name; }
        }

        public String Symbol
        {
            get { return _symbol; }
        }

        public Unit(String name, String symbol)
        {
            this._name = name;
            this._symbol = symbol;
        }

        
    }
}
