using System;
public class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {   
        Console.WriteLine();
        return  $"{_date.ToString("dd MMM yyyy")} {TypeOfActivity()} ({_length} min) - " +
                $"Distance: {Math.Round(GetDistance())} miles, Speed: {Math.Round(GetSpeed())} mph, " +
                $"Pace: {Math.Round(GetPace())} mins per mile";
        
    }
    public virtual string TypeOfActivity()
    {
        return "Generic Activity";
    }
    
}