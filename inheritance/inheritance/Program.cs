using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            chef chef = new chef();
            chef.MakeChicken();

            Italianchef italianchef= new Italianchef();
            italianchef.MakePasta();

            Console.ReadLine();
        }
    }
}
