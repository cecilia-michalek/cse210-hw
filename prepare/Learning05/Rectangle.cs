using System;


public class Rectangle : Shape
{
    private double _side1 = 1;
    private double _side2 = 1;

    public Rectangle(string color, double side1, double side2) : base(color)
    {
        _side1 = side1;
        _side2 = side2;
    }

    public double GetSide1()
    {
        return _side1;

    }
    public void SetSide1(double side1)
    {
        _side1 = side1;
    }
    public double GetSide2()
    {
        return _side2;

    }
    public void SetSide2(double side2)
    {
        _side2 = side2;
    }

    public override double GetArea()
    {
        return _side1 * _side2;
    }

}