using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    public class Voter
    {

        public string Name;

        public int Age;

        public Voter()
        {
            Name = "Abc";

            Age = 0;
        }

        public Voter(string _Name, int _Age)
        {
            Name = _Name;

            Age = _Age;
        }

        public String EligibleOrNotEligible()
        {
            string result ="Eligible";

            if (Age > 18 && Age < 110)
            {
                result ="Eligible";
            }
            else
            {
                result ="Not Eligible";
            }
            return result;
        }
    }
}
