using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
     public static class Number
    {
        private static int i = 10;

        public static string Name = "test";
        /*public static  Number()
        {
            i = 10;
        }

        public Number(int _n)
        {
            i = _n;
        }

        public Number(string _name)
        {
            Console.WriteLine("please provide only integer value");
        }*/

       /* ~Number()
        {
            Console.WriteLine("Object Destroyed");
        }
       */

        public static void oddeven()
        {
           
            for (int j = 1; j <= i; j++)
            {
                if (j % 2 == 0)
                    Console.WriteLine("number" + j + "is even");
                else
                    Console.WriteLine("number" + j + "is odd");
            }
        }
    }
}
