using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;

        while(num != 0)
        {
            Console.WriteLine("Enter a list of Number, Type 0 when finish");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        int result = 0;
        foreach(int number in numbers)
        {
            result += number;
        }

        Console.WriteLine($"The Sum Is: {result}");

        float average = ((float)result)/numbers.Count;

        Console.WriteLine($"The Average Is: {average}");

        int max = numbers [0];
        foreach( int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The max is: {max}");
    }
    
    
}

