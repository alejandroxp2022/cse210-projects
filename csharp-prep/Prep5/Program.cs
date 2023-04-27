using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static void PromptUserName()
        {

            Console.Write($"Please enter your name:");
            String username = Console.ReadLine();
        }

        static int PromptUserNumber(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    }
}