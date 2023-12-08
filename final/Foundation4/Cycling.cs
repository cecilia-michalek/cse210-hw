using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * _length;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string TypeOfActivity()
    {
        return "Cycling";
    }
    
    
}