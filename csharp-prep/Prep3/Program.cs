using System;

class Program
{
    static void Main(string[] args)
    {

        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int magic_number;
            //Console.WriteLine("What is the magic number?");
            //magic_number =  int.Parse(Console.ReadLine());
            magic_number = number;

            int guess_number;
            guess_number = -1;

            while ( magic_number != guess_number )
            {
                Console.WriteLine("What is your guess?");
                guess_number = int.Parse(Console.ReadLine());
                if (guess_number > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                if (guess_number < magic_number)
                {   
                    Console.WriteLine("Higher");
                }
                if (guess_number == magic_number)
                {   
                    Console.WriteLine("You Guessed It!");
                }

            }

            Console.WriteLine("Do you want to continue?");
            response = Console.ReadLine();
        
        }
    }
}