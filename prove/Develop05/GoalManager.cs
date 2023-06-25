using System;

//class GoalManager: Goal
class GoalManager
{
    //fields
//    private List<Goal> _goals;
    protected List<SimpleGoal> SimpleGoals = new List<SimpleGoal>();
    protected List<EternalGoal> EternalGoals = new List<EternalGoal>();
    protected List<ChecklistGoal> ChecklistGoals = new List<ChecklistGoal>();
    protected string _filename;
    private string _separator = "|";
    public int _totalPoints;
    public void CreateGoalMenu()
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
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.CreateGoal();
                            SimpleGoals.Add(simpleGoal);
                            break;
                        case "2":
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.CreateGoal();
                            EternalGoals.Add(eternalGoal);
                            break;
                        case "3":
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.CreateGoal();
                            ChecklistGoals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Please select the right option.");
                        break;
                    }
    }

    //  override public void ListGoals()
    //  {
    //     int counter = 0 ;
    //     foreach ( SimpleGoal goal in SimpleGoals)
    //     {
    //         counter++;
    //         Console.WriteLine($"{counter}.- [{_goalCheck}] {goal} ({goal})");
    //     }
    
    //public void ListAllGoals(SimpleGoal simpleGoal, EternalGoal eternalGoal, ChecklistGoal checklistGoal)
    public void ListAllGoals()
    {
        Console.WriteLine("The goals are:");
        int counter = 0 ;
        foreach ( SimpleGoal goal in SimpleGoals)
        {
            counter++;
                string _checkS = " ";
                if (goal.getStatus() == true) {
                    _checkS = "X";
                }
                
                Console.WriteLine($"{counter}.- [{_checkS}] {goal.getName()} ({goal.getDesc()})");
        }
        foreach ( EternalGoal goal in EternalGoals)
        {
                 string _checkE = " ";
            counter++;
            Console.WriteLine($"{counter}.- [{_checkE}] {goal.getName()} ({goal.getDesc()})");
        }
        foreach ( ChecklistGoal goal in ChecklistGoals)
        {
                  string _checkC = " ";
                if (goal.getStatus() == true) {
                    _checkC = "X";
                }
           counter++;
            Console.WriteLine($"{counter}.- [{_checkC}] {goal.getName()} ({goal.getDesc()})  -- Currently completed: {goal.getCount()}/{goal.getTimes()}");
        }
    }
    //public void SaveAllGoals(SimpleGoal simpleGoal, EternalGoal eternalGoal, ChecklistGoal checklistGoal)
    public void SaveAllGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            //total points first
            outputFile.WriteLine($"{_totalPoints}");
            //now the goals by type
            foreach (SimpleGoal entry in SimpleGoals)
            {
                outputFile.WriteLine($"SimpleGoal{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}{_separator}{entry.getStatus()}");
            }
            foreach (EternalGoal entry in EternalGoals)
            {
                outputFile.WriteLine($"EternalGoal{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}");
            }
            foreach (ChecklistGoal entry in ChecklistGoals)
            {
                outputFile.WriteLine($"ChecklistGoal{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}{_separator}{entry.getBonus()}{_separator}{entry.getTimes()}{_separator}{entry.getCount()}");
            }
          
        }
    }
    public void LoadGoals()
 {
        // To not load entries repeatedly 

        using (StreamReader inputFile = new StreamReader(_filename))
        {
            _totalPoints = Convert.ToInt16(Console.ReadLine());
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //string prompt = parts[1].Split(':')[0].Trim();
                if ( parts[0] == "SimpleGoal")
                {
                    SimpleGoal _simpleGoal = new SimpleGoal(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToBoolean(parts[4].Trim()));
                    SimpleGoals.Add(_simpleGoal);

                }
                if ( parts[0] == "EternalGoal")
                {
                    EternalGoal _eternalGoal = new EternalGoal(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3].Trim()));
                    EternalGoals.Add(_eternalGoal);
                }
                if ( parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal _checklistGoal = new ChecklistGoal(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToInt16(parts[4]),Convert.ToInt16(parts[5]),Convert.ToInt16(parts[6].Trim()));   
                    ChecklistGoals.Add(_checklistGoal);

                }
                    
            }
        }
    }
    public void RecordEvent()
    {
        //SimpleGoal.Add(entry);
    }
} 