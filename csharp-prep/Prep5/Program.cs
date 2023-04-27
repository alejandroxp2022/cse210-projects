using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);

        static void DisplayWelcome() => Console.WriteLine("Welcome to the Program!");

        static string PromptUserName()
        {

            Console.Write($"Please enter your name:");
            String username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write($"Please enter your favorite number:");
            int fav_num = int.Parse(Console.ReadLine());
            return fav_num;
        }

        static int SquareNumber( int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult( string name, int square)
        {
            Console.Write($"{name}, the square of your number: {square}");
        }
    }
}