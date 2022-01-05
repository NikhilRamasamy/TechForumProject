using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    public class Hellodays
    {
        public int daynum { get; set; }

        public Hellodays(int day)
        {
            daynum = day;
        }

        ~Hellodays()
        {
            Console.WriteLine("memory is freeing here");
        }

    

        public void displayday()
        {
            switch(daynum)
            {
                case 1:
                    Console.WriteLine("Sunday");break;

                case 2:
                    Console.WriteLine("Monday"); break;

                case 3:
                    Console.WriteLine("Tuesday"); break;

                case 4:
                    Console.WriteLine("Wednesday"); break;

                case 5:
                    Console.WriteLine("Thursday"); break;
                case 6:
                    Console.WriteLine("Frriday"); break;
                case 7:
                    Console.WriteLine("Saturday"); break;



            }
        }

    }
}
