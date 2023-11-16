using System;

public class EternalGoal : Goal {

    public EternalGoal(string goalType, string shortName, string goalDescription, int point) : base(goalType, shortName, goalDescription, point, false)
    {

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "[ ]";   
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