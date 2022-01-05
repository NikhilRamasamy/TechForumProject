using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace biginner1
{


    //Building a guessing game

  /*  class bagg
    {
        static void Main(string[] args)
        {
            string secretword = "password";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while(guess != secretword && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess = true;
                }
            }
            if(outOfGuess)
            {
                Console.Write("You Lose!");  
            }
            else
            {
                Console.Write("you win!");
            }
            

            Console.ReadLine();
        }
    }*/

//For loop

 /*   class fl
    {
        static void Main(string[] args)
        {
            
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }*/

//Building an exponent method

  /*  class baem
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine(numberGrid[0, 0]);


            Console.ReadLine();
        }
    }*/

//Exception Handling  

    class eh
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine(e.Message); 
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

            Console.ReadLine();
        }
    }
}
