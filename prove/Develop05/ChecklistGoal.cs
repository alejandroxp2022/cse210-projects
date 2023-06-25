using System;

class ChecklistGoal: Goal
{
    // protected _length ; 
    // protected double _width; 

    protected List<ChecklistGoal> _checklistGoals;
    protected List<ChecklistGoal> ChecklistGoals { get { return _checklistGoals; } set => _checklistGoals = value;} 
    public ChecklistGoal(string goalType, string goalName, string goalDesc, int goalPoints): base (goalType,goalName,goalDesc,goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _goalPoints = goalPoints;
    }
    public ChecklistGoal()
     {
        _goalType = "";
        _goalName = "";
        _goalDesc = "";
        _goalPoints = 0;
     }

     public List<ChecklistGoal> GetGoals()
     {
        return _checklistGoals;
     }
}