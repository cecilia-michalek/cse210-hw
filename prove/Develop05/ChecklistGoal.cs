using System;
using System.Runtime;

public class ChecklistGoal : Goal {
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string goalType, string shortName, string goalDescription, int point, int target, int bonus, bool isComplete) : base(goalType, shortName, goalDescription, point, isComplete)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    { 
        return _amountCompleted >= _target;   
    }
    public override string GetDetailsString()
    {
        return $"{_goalDescription} (Completed {_amountCompleted}/{_target} times)";
    }
    public override string GetStringRepresentation()
    {
       return IsComplete() ? "[X]": "[ ]"; 
    }
    public int GetBonusPoints()
    {
        return IsComplete() ? _bonus : 0;
    }
    public override string GetGoalType()
    {
        return _goalType;
    }
    public override string GetGoalName()
    {
        return _shortName;
    }
}