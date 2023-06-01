using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment("Alejandro Pena", "BYUIdaho Experience");
        MathAssignment mathAssignment1 = new MathAssignment("Benito", "El Marciano", "7.3", "8-19");        
        WritingAssignment writeAssignment1 = new WritingAssignment("Cachupin", "El Perro bueno", "Coleccion de cuentos");        

        Console.WriteLine("------Testing Assignment Class--");
        Console.WriteLine($"{assignment1.GetSummary()}");
        Console.WriteLine("------Testing MathAssignment Class--");
        Console.WriteLine($"{mathAssignment1.GetSummary()}");
        Console.WriteLine($"{mathAssignment1.GetHomeworkList()}");
        Console.WriteLine("------Testing WriteAssignment Class--");
        Console.WriteLine($"{writeAssignment1.GetSummary()}");
        Console.WriteLine($"{writeAssignment1.GetWritingInformation()}");
    }
}