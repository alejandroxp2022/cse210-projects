using System;

class SimpleGoal: Goal
{
    // protected _length ; 
   // protected List<SimpleGoal> _simpleGoals;
   // protected List<SimpleGoal> SimpleGoals { get { return _simpleGoals; } set => _simpleGoals = value;} 

    protected bool _goalCheck;
     public bool getStatus() { return _goalCheck; }
    public SimpleGoal(string goalType, string goalName, string goalDesc, int goalPoints, bool goalStatus): base (goalType,goalName,goalDesc,goalPoints)
    { 
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
        _goalCheck = goalStatus;
    }
    public SimpleGoal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
        _goalCheck = false;
     }

    //  public List<SimpleGoal> GetGoals()
    //  {
    //     return _simpleGoals;
    //  }


    //  override public void ListGoals()
    //  {
    //     int counter = 0 ;
    //     foreach ( SimpleGoal goal in _simpleGoals)
    //     {
    //         counter++;
    //         Console.WriteLine($"{counter}.- [{_goalCheck}] {goal} ({goal})");
    //     }
    // }



}