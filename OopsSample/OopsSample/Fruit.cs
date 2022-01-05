using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    public class Fruit
    {
        public Fruit(string _name, string  _growingSeason)
        {
            Name = _name;
            GrowingSeason = _growingSeason;
        }

        public string Name;

        public string GrowingSeason;

        bool IsDeterminent()
        {
            bool result = false;

            // Logic here


            return result;
        }
    }
}

