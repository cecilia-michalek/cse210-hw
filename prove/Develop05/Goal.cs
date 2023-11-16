using System;

public abstract class Goal
{
    protected string _goalType;
    protected string _shortName;
    protected string _goalDescription;
    protected int _point;

    protected bool _isComplete;

    public Goal(string goalType, string shortName, string goalDescription, int point, bool isComplete)
    {
        _goalType = goalType;
        _shortName = shortName;
        _goalDescription = goalDescription;
        _point = point;
        _isComplete = isComplete;

    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    public abstract string GetGoalType();
    public abstract string GetGoalName();

    public int GetPoints()
    {
        return _point;
    }

    public void SetCompletedStatus(bool isComplete)
    {
        _isComplete = isComplete;
    }
}