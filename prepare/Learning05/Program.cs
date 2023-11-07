using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        Square squareShape = new Square();
        squareShape.SetColor("Blue");
        squareShape.SetSide(10);

        Rectangle rectangleShape = new Rectangle();
        rectangleShape.SetSide1(5);
        rectangleShape.SetColor("Red");
        rectangleShape.SetSide2(15);

        Circle circleShape = new Circle();
        circleShape.SetColor("Yellow");
        circleShape.SetRadius(10);

        shapes.Add(squareShape);
        shapes.Add(rectangleShape);
        shapes.Add(circleShape);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"{color}, {area}");
        }
    }

}