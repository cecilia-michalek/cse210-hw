using System;

public class SimpleGoal : Goal 
{
    public SimpleGoal(string goalType, string shortName, string goalDescription, int point, bool isComplete) : base (goalType, shortName, goalDescription, point, isComplete) 
    {
        _isComplete = false;

    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
       return _isComplete; 
        
    }
    public override string GetStringRepresentation()
    {
        return _isComplete ? "[X]" : "[ ]";
        
    }
    public override string GetDetailsString()
    {
        return _goalDescription;
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