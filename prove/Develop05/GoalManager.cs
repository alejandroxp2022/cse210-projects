using System;

class GoalManager: Goal
{
    //fields
//    private List<Goal> _goals;
//    protected List<Goal> Goals { get { return _goals; } set => _goals = value; }
//    protected string _filename;
//    protected int _goalType;
//    protected string _goalName;
//    protected string _goalDesc;
//    protected int _goalPoints;
//    protected bool _goalCheck;
    public int _totalPoints;
    //List<SimpleGoal> _simpleGoal_list = new List<SimpleGoal>();
    //List<EternalGoal> _eternalGoal_list = new List<EternalGoal>();
    //List<ChecklistGoal> _checklistGoal_list = new List<ChecklistGoal>();

    // public GoalManager(string goalType, string goalName, string goalDesc, int goalPoints ): base(goalType, goalName, goalDesc, goalPoints )
    //  {
    //     _goalType = goalType;
    //     _goalName = goalName;
    //     _goalDesc = goalDesc;
    //     _goalPoints = goalPoints;
    //     //_totalPoints = goalPoints;
    //  }
    // public GoalManager()
    //  {
    //     _goalType = "";
    //     _goalName = "";
    //     _goalDesc = "";
    //     _goalPoints = 0;
    //  }


    public void CreateGoalMenu(SimpleGoal simpleGoal, EternalGoal eternalGoal, ChecklistGoal checklistGoal)
    {
        string _tecla2;
        Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("     1. Simple Goal");
                    Console.WriteLine("     2. Eternal Goal");
                    Console.WriteLine("     3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create?");
                    _tecla2  = Console.ReadLine();
                    switch (_tecla2)
                    {
                        case "1":
        //                    SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.CreateGoal();
                            break;
                        case "2":
        //                    EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.CreateGoal();
                            break;
                        case "3":
        //                    ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.CreateGoal();
                            break;
                        default:
                            Console.WriteLine("Please select the right option.");
                        break;
                    }
    }

    public void ListAllGoals(SimpleGoal simpleGoal, EternalGoal eternalGoal, ChecklistGoal checklistGoal)
    {
        Console.Write("The goals are");
        int counter = 0 ;
        foreach ( SimpleGoal goal in simpleGoal.GetGoals())
        {
            counter++;
            Console.WriteLine($"{counter}.- [{_goalCheck}] {goal} ({goal})");
        }
        foreach ( EternalGoal goal in eternalGoal.GetGoals())
        {
            counter++;
            Console.WriteLine($"{counter}.- [{_goalCheck}] {goal} ({goal})");
        }
        foreach ( ChecklistGoal goal in checklistGoal.GetGoals())
        {
            counter++;
            Console.WriteLine($"{counter}.- [{_goalCheck}] {goal} ({goal})");
        }
    }
    public void SaveAllGoals(SimpleGoal simpleGoal, EternalGoal eternalGoal, ChecklistGoal checklistGoal)
    {
        Console.WriteLine("What is the filename for the goal file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (SimpleGoal entry in simpleGoal.GetGoals())
            {
                outputFile.WriteLine($"SimpleGoal:{entry.getName()},{entry.getDesc()},{entry.getPoints},{entry.getStatus()}");
            }
            foreach (EternalGoal entry in eternalGoal.GetGoals())
            {
                outputFile.WriteLine($"EternalGoal:{entry.getName()},{entry.getDesc()},{entry.getPoints}");
            }
            foreach (ChecklistGoal entry in checklistGoal.GetGoals())
            {
                outputFile.WriteLine($"SimpleGoal:{entry.getDesc()},{entry.getStatus()}");
            }
          
        }
    }
    public void LoadGoals()
 {
        // To not load entries repeatedly 
        //Goal.Clear();

        using (StreamReader inputFile = new StreamReader(_filename))
        {
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                //string[] parts = line.Split(new[] { " - Prompt: " }, StringSplitOptions.None);
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //DateTime date = DateTime.ParseExact(parts[0].Replace("Date: ", ""), "M/d/yyyy", null);
                DateTime date = DateTime.ParseExact(parts[0], "M/d/yyyy", null);

                //string prompt = parts[1].Split(':')[0].Trim();
                string prompt = parts[1];
                //Console.WriteLine($"Prompt part: {prompt}");
                    
                //string response = parts[1].Split(':')[1].Trim();
                string response = parts[2].Trim();
                //Console.WriteLine($"Response part: {response}");
            
                //Goal goals = new Goal(prompt, response);
                //entry._date = date;
                //entries.Add(entry);
            }
        }
    }
    public void RecordEvent()
    {
        //SimpleGoal.Add(entry);
    }
} 