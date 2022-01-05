using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    /*  class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("hello World");
              Console.ReadLine(); 
          }
      }*/
    /* class variex
     {
         static void Main(string[] args)
         {
             string characterName = "john";
             int characterAge;
             characterAge = 35;
             Console.WriteLine("There once was a man named " + characterName);
             Console.WriteLine("He was " + characterAge + " years old");
             Console.WriteLine("He really liked the name " + characterName);
             Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
         }
     }*/
  /*  class datatype

    {
        static void Main(string[] args)
        {
            string phrase = "Cricket Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;

            Console.WriteLine(30);

            Console.ReadLine();
        } 
    }*/
//working with string
/*
class wws
    {
      static void Main(string[] args)
        {
            string phrase = "MS Dhoni is called as" + " captain cool";
            Console.WriteLine(phrase.Substring(30));

            Console.ReadLine();
        }
    }*/

//working with numbers
/*
class wwn
    {
      static void Main(string[] args)
        {
            int num = 7;
            num++;
            Console.WriteLine(Math.Max(4,7) );


            Console.ReadLine();
        }
    }*/

//Getting user input

    class Gui
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            Console.ReadLine();
        }
    }
// Building a calculator

  /*  class bac
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2); 

            Console.ReadLine();
        }
    }*/

//Building a mad libs game
/*
    class madlibsgame
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Indian jerssey are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine(" I Love " + celebrity);


            Console.ReadLine();
        }
    }*/
}
 