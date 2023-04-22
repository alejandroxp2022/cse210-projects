using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());

        string sign = "";
        string letter = "";

        sign = determine_sign(percentage);
        if (percentage >= 90)
        {
            letter = $"A{sign}";
        }
        else if (percentage >= 80)
        {
            letter = $"B{sign}";
        }
        else if (percentage >= 70)
        {
            letter = $"C{sign}";
        }
        else if (percentage >= 60)
        {
            letter = $"D{sign}";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you have not passed");
        }
        
        string determine_sign(int percentage)
        {
            string sign = "";
            string percent_str = percentage.ToString();
            int last_digit_str = int.Parse(percent_str.Substring(1));
            if(last_digit_str >= 7 && percentage < 90 )
                {
                 sign = "+";   
                }
            else 
                {
                    if (last_digit_str < 3)
                    {
                        sign = "-";
                    }
                
                }
            return sign;

        }
    }
}