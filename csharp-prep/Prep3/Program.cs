using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int guess = -1;

            while(guess != number)
            {
                Console.WriteLine("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());

                if(guess < number)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("==============================================");
                }

                else if(guess > number)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("****************************************************");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("");
                }

            }

           

        }

    }
}
