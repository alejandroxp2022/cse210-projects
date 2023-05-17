using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new journal
        Journal myJournal = new Journal();
        // Welcome
        Console.Write($"Welcome to the Journal Program!\n");
        // To be used storing or loading journal in option 3 and 4.
        string filename;
        // Create a list of prompts
        List<string> prompts = new List<string>
        {
            "What was the best thing that happened to you today?",
            "What did you learn recently that you found interesting?",
            "What is something you're looking forward to?",
            "Describe a moment when you felt proud of yourself.",
            "What is something you'd like to improve about yourself?"
        };
        int promptIndex = 0;
        int newpromptIndex = 0;
 

        // Loop until the user chooses to quit
        while (true)
        {
            // Display a menu of options
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write journal entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");

            // Prompt the user to choose an option
            Console.Write("\nWhat would you like to do? ");
            string option = Console.ReadLine();
            
            switch (option)
            {
                case "1":

                    // Choose a random prompt from the list
                    Random random = new Random();
                    // Discard repeated prompts.
                    do
                    {
                        newpromptIndex = random.Next(prompts.Count);
                    } while (promptIndex == newpromptIndex);
                    promptIndex = newpromptIndex;
                    string prompt = prompts[promptIndex];

                    // Prompt the user for a response to the selected prompt
                    Entry newEntry = new Entry(prompts[promptIndex], "");
                    Console.WriteLine($"{newEntry._prompt} ");
                    Console.Write("> ");
                    newEntry._response = Console.ReadLine();

                    // Add the new entry to the journal
                    myJournal.AddEntry(newEntry);

                    Console.WriteLine("\nEntry added to journal.");
                    break;

                case "2":
                    // Display all existing entries
                    myJournal.DisplayEntries();
                    break;

                case "3":
                    // Prompt the user for a filename to save the journal to
                    Console.Write("Enter a filename to save the journal to: ");
                    filename = Console.ReadLine();

                    // Save the journal to the file
                    myJournal.SaveToFile(filename);

                    Console.WriteLine("\nJournal saved to file.");
                    break;

                case "4":
                    // Prompt the user for a filename to load the journal from
                    Console.Write("Enter a filename to load the journal from: ");
                    filename = Console.ReadLine();

                    // Load the journal from the file
                    myJournal.LoadFromFile(filename);

                    Console.WriteLine("\nJournal loaded from file.");
                    break;

                case "5":
                    // Quit the program
                    Console.WriteLine("\nGoodbye!");
                    return;

                default:
                    // Invalid option
                    Console.WriteLine("\nInvalid option. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
