using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginner
{
    //array
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5];
            friends[0] = "jim";
            friends[1] = "kelly";
            friends[2] = "smith";
            friends[3] = "warner";
            friends[4] = "wade";

            Console.WriteLine(friends[2]);

            Console.ReadLine();
        }
    }*/

    //methods

    /* class m
     {
         static void Main(string[] args)
         {
             SayHi("Nikhil",22);
             SayHi("Yazh",10);
             SayHi("Akhil",7);

             Console.ReadLine();
         }
         static void SayHi(string name, int age)
         {
             Console.WriteLine("Hello " + name + " you are " + age); 
         }
     }*/

    //return statement

    /* class rt
     {
         static void Main(string[] args)
         {
             Console.WriteLine(cube(5));

             int cubedNumber = cube(5);
             Console.WriteLine(cubedNumber);

             Console.ReadLine();
         }
         static int cube(int num)
         {
             int result = num * num * num;
             return result;
         }
     }*/

    //if statement
    /*
        class Is
        {
             static void Main(string[] args)
             {
                 bool isMale = true;
                 bool isTall = true;

                 if (isMale && isTall)
                 {
                     Console.WriteLine("you are a tall male");
                 }else
                 {
                     Console.WriteLine("you are either not male or not tall or both");
                 }

                 Console.ReadLine();

             }*/
    /*  static void Main(string[] args)
      {
          bool isMale = true;
          bool isTall = true;

          if (isMale && isTall)
          {
              Console.WriteLine("you are a tall male");
          }else if (isMale && !isTall)
          {
              Console.WriteLine("you are a short male");
          }else if (!isMale && isTall)
          {
              Console.WriteLine("yor are not a male but you are tall");
          }else

          {
              Console.WriteLine("you are not male and not tall");
          }

          Console.ReadLine();

      }

  }*/

    // more if statement
    /*
        class mis
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GetMax(25, 53, 73));

                Console.ReadLine();
            }
            static int GetMax(int num1, int num2, int num3)
            {
                int result;
                if (num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                }else if(num2 >= num1 && num2 >= num3)
                {
                    result = num2; 
                }
                else
                {
                    result = num3;
                }

                return result;
            }
        }*/

    ///Building a better calculator
    /*
        class babc
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter a number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2); 
                }else if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (op == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (op == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine("Invalid operator");
                }


                Console.ReadLine();

            }
        }*/

    //Switch statements
/*
    class ss
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));

            Console.ReadLine();
        }
        static string GetDay(int daynum)
        {
            string dayName;

            switch (daynum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;

            }

            return dayName;


        }
    }*/

    //while loops

   class wl
    {
      /*  static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {

                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }*/
      static void Main(string[] args)
        {
            int index = 4;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            Console
                .ReadLine();
        }

        
    }
}
