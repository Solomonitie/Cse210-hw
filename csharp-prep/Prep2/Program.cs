using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage!");
        int grade = Console.ReadLine();

        if(grade >= 90)
        {
            Console.WriteLine("Your Grade is --> A");
        }

        if(grade >= 90)
        {
            Console.WriteLine("Your Grade is --> A");
        }

        else if(grade >= 80)
        {
            Console.WriteLine("Your Grade is --> B");
        }

        else if(grade >= 70)
        {
            Console.WriteLine("Your Grade is --> C");

        }

        else if(grade >= 60)
        {
            Console.WriteLine("Your Grade is --> E");

        }

        else
        {
            Console.WriteLine("Your Grade is --> F");
        }

        
    }
}