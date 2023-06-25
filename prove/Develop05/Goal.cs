using System;

abstract class Goal
{
    //fields
    //protected List<Goal> _goals;
   // protected List<Goal> Goals { get { return _goals; } set => _goals = value; }
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;
    protected int _goalTimes;
    protected int _goalCount;
    //protected int _totalPoints;
     public string getName() { return _goalName; }
     public string getType() { return _goalType; }
     public string getDesc() { return _goalDesc; }
     public int getPoints() { return _goalPoints; }
     public int getTimes() { return _goalTimes; }
     public int getCount() { return _goalCount; }
    public Goal(string goalType, string goalName, string goalDesc, int goalPoints )
     {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalTimes = 1;
        _goalCount = 0;
        //_totalPoints = goalPoints;
     }
    public Goal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
        _goalTimes = 1;
        _goalCount = 0;
     }

// //    public void AddEntry(Goal entry)
//     {
//         Goals.Add(entry);
//     }
    virtual public void CreateGoal()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _goalPoints = Convert.ToInt16(Console.ReadLine());

    }
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