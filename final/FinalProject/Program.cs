using System;

class Program
{
    static void Main(string[] args)
    {
        string _tecla;
         PowerPlantManager powerPlantManager = new PowerPlantManager();
        do {
            //Console.Clear();
            Console.WriteLine("Status");
            Console.WriteLine($"You have {powerPlantManager._totalPoints} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Entity");
            Console.WriteLine("     2. List Devices");
            Console.WriteLine("     3. Save Power Plant Image");
            Console.WriteLine("     4. Load Power Plant Image");
            Console.WriteLine("     5. Record Events");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            _tecla  = Console.ReadLine();
            switch (_tecla)
            {
                case "1": 
                    //powerPlantManager.CreateGoalMenu(simpleGoal,eternalGoal,checklistGoal);
                    powerPlantManager.CreatePowerPlant();
                    break;
                case "2":
                    //powerPlantManager.ListAllGoals(simpleGoal,eternalGoal,checklistGoal);
                    powerPlantManager.ListAllGoals();
                    break;
                case "3":
                    //powerPlantManager.SaveAllGoals(simpleGoal,eternalGoal,checklistGoal);
                    powerPlantManager.SaveAllGoals();
                    break;
                case "4":
                    powerPlantManager.LoadGoals();
                    break;
                case "5":
                    powerPlantManager.RecordEvent();
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