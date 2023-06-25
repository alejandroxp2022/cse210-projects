using System;

class EternalGoal: Goal
{
    // protected _length ; 
    // protected double _width; 

    // protected List<EternalGoal> _eternalGoals;
    // protected List<EternalGoal> EternalGoals { get { return _eternalGoals; } set => _eternalGoals = value;} 
    public EternalGoal(string goalType, string goalName, string goalDesc, int goalPoints): base (goalType,goalName,goalDesc,goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
    }
    public EternalGoal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
     }

    //  public List<EternalGoal> GetGoals()
    //  {
    //     return _eternalGoals;
    //  }
}