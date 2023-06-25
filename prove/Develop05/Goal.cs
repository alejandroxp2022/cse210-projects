using System;

abstract class Goal
{
    //fields
    protected List<Goal> _goals;
    protected List<Goal> Goals { get { return _goals; } set => _goals = value; }
    protected string _filename;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;
    protected bool _goalCheck;
    //protected int _totalPoints;
     public string getName() { return _goalName; }
     public string getType() { return _goalType; }
     public string getDesc() { return _goalDesc; }
     public int getPoints() { return _goalPoints; }
     public bool getStatus() {return _goalCheck; }
    public Goal(string goalType, string goalName, string goalDesc, int goalPoints )
     {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        //_totalPoints = goalPoints;
     }
    public Goal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
     }

    public void AddEntry(Goal entry)
    {
        Goals.Add(entry);
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _goalPoints = Convert.ToInt16(Console.ReadLine());

    }
    virtual public void ListGoals() { }
    // public void SaveGoals( string filename)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach (Goal entry in Goals)
    //         {
    //             outputFile.WriteLine($"{entry._date.ToShortDateString()}|{entry._prompt}|{entry._response}");
    //         }
    //     }
    // }
    // public void LoadGoals()
    // {
    //     //Console.WriteLine("Well done!!");
    //     Console.WriteLine("");
    //     Console.WriteLine($"You have completed another {_durationInSeconds} seconds of the {_activityName} Activity");
    // }
    public void RecordEvent()
    {
        var symbols = new List<string> {"5","4","3","2","1"};
        foreach (var symbol in symbols)
        {
            Console.Write($"{symbol}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            //Console.Write("-"); // Replace it with the - character
        }
    }
} 