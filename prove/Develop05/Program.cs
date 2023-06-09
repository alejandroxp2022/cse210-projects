using System;

class Program
{
    static void Main(string[] args)
    {
        string _tecla;
         GoalManager goalManager = new GoalManager();
        do {
            //Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"You have {goalManager._totalPoints} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Events");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            _tecla  = Console.ReadLine();
            switch (_tecla)
            {
                case "1": 
                    //goalManager.CreateGoalMenu(simpleGoal,eternalGoal,checklistGoal);
                    goalManager.CreateGoalMenu();
                    break;
                case "2":
                    //goalManager.ListAllGoals(simpleGoal,eternalGoal,checklistGoal);
                    goalManager.ListAllGoals();
                    break;
                case "3":
                    //goalManager.SaveAllGoals(simpleGoal,eternalGoal,checklistGoal);
                    goalManager.SaveAllGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Good Bye.");
                    break;
                default:
                    Console.WriteLine("Please select the right option.");
                    break;

            }

        } while (_tecla != "6");
    }
}