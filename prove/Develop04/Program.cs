using System;

class Program
{
    static void Main(string[] args)
    {
        string _tecla;
        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Start find the keyword activity");
            Console.WriteLine("     5. Quit");
            Console.Write("Select a choice from the menu: ");
            _tecla  = Console.ReadLine();
            switch (_tecla)
            {
                case "1": 
                    BreathingActivity Breath = new BreathingActivity();
                    Breath.RunActivity();
                    break;
                case "2":
                    ReflectingActivity Reflect = new ReflectingActivity();
                    Reflect.RunActivity();
                    break;
                case "3":
                    ListActivity Listing = new ListActivity();
                    Listing.RunActivity();
                    break;
                case "4":
                    Console.WriteLine("Extra Bonus!");
                    FindTheKeywordActivity FindTheKey = new FindTheKeywordActivity();
                    FindTheKey.RunActivity();
                    break;
                case "5":
                    Console.WriteLine("Good Bye.");
                    break;
                default:
                    Console.WriteLine("Please select the right option.");
                    break;

            }

        } while (_tecla != "5");
    }
}