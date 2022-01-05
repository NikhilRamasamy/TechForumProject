using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunTypes
{
    class Funct
    {
       public int num1=2, num2=3,res;

        public void add(int a,int b)
        {
            res = a + b;
        }
        //fubction with return and no parameters
        public int sub()
        {
            res = num1 + num2;
            return res;
        }
        //fuct calling another fuct
        public int anoFunc(int a,int b)
        {
            res = add(a, b);
            return res;
        }
        // fuction with parameters and return
        public int mul(int a,int b)
        {
            int r = a * b;
            return r;
        }

        

    }
}
