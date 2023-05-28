using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Scripture and Reference
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture(); 

        //Giving a test value to this objects
        _reference.setReference("John 13:16");
        string scripture_text = "Verily, verily, I say unto you, The servant is not greater than his lord; neither he that is sent greater than he that sent him.";
        _scripture.setScripture(scripture_text);

        Console.WriteLine("\nThis is the scripture to memorize:");
        Console.WriteLine("" + _reference.toString() + ": " + scripture_text );
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string inputKey = Console.ReadLine();
        Console.Clear();
        if (inputKey != "quit")
        {
            do {
                Console.WriteLine( "" + _reference.toString() + ": " + _scripture.toString());
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                inputKey = Console.ReadLine();
                Console.Clear();
            } while ( (!_scripture.isHiddenScripture()) || (inputKey != "quit"));
        }
    }
}