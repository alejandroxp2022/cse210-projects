using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int answer = -1;
        int min_positive = 100000;
        int old_answer = 10000000;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (answer != 0)
        {
            old_answer = answer;
            Console.Write("Enter number:");
            answer = int.Parse(Console.ReadLine());

            if (answer != 0)
            {
                numbers.Add(answer);
                if (answer > 0 && answer < old_answer)
                {
                    min_positive = answer;
                }
            }
        }
        Console.WriteLine($"The sum is:{numbers.Sum()}");
        Console.WriteLine($"The average is:{numbers.Average()}");
        Console.WriteLine($"The largest number is:{numbers.Max()}");
        Console.WriteLine($"The smallest positive number is:{min_positive}");

        Console.WriteLine($"The sorted list is:");
        foreach ( int number in numbers )
            {
                Console.WriteLine(number);
            }



    }
}