using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World! Fractions Activity");
        Console.WriteLine("Verify that you can create fractions using all three of these constructors.");
        Console.WriteLine("\nCreate an instance for 1/1 (using the first constructor):");
        Fraction fraction0 = new Fraction();
        Console.WriteLine(fraction0.GetFractionString());
        Console.WriteLine(fraction0.GetDecimalValue());

        Console.WriteLine("\nFor 6/1 (using the second constructor):");
        Fraction fraction1 = new Fraction(6);
        //fraction1.SetTop(6);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine("\nFor 6/7 (using the third constructor):");
        Fraction fraction2 = new Fraction(6,7);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue().ToString("F2"));

        Console.WriteLine("\nVerify that you can call all of these methods " +
        "\nand get the correct values, using setters to change the values and then getters to " + 
        "\nretrieve these new values and then display them to the console:");
        Fraction fraction = new Fraction();
        Console.WriteLine("\nSetting Top = 5  and Botton = 9");
        fraction.SetTop(5);
        Console.WriteLine(fraction.GetTop());
        fraction.SetBottom(9);
        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue().ToString("F2"));

        Console.WriteLine("\nCreate a method called GetFractionString that returns the fraction in the form 3/4" +
        "\nand Create a method called GetDecimalValue that returns a double that is the result of" + 
        "\ndividing the top number by the bottom number, such as 0.75.:");
        Fraction fraction3 = new Fraction();
        Console.WriteLine("\nSetting Top = 3  and Botton = 4");
        fraction3.SetTop(3);
        Console.WriteLine(fraction3.GetTop());
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue().ToString("F2"));

        Console.WriteLine("\nSetting Top = 1  and Botton = 3");
        fraction3.SetTop(1);
        Console.WriteLine(fraction3.GetTop());
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue().ToString("F2"));



    }
}