using System;

class ChecklistGoal: Goal
{
     protected int _goalBonus ; 
    protected bool _goalCheck;
     public int getBonus() { return _goalBonus; }
     public bool getStatus() { return _goalCheck; }
    public ChecklistGoal(string goalType, string goalName, string goalDesc, int goalPoints, int goalBonus, int goalTimes, int goalCount): base (goalType,goalName,goalDesc,goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalBonus = goalBonus;
        _goalTimes = goalTimes;
        _goalCount = goalCount;
    }
    public ChecklistGoal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
     }
    override public void CreateGoal()
    {
        //Console.Clear();
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _goalPoints = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        _goalTimes = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        _goalBonus = Convert.ToInt16(Console.ReadLine());
    }
     public void setChecked(int goalTimes, int goalCount) { 
        if (goalCount >= goalTimes)
        {
            _goalCheck = true; 
        }
     }
    public void setCount(int goalCount){
        _goalCount = goalCount;
    }
}