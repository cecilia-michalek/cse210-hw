using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assingnment assingnment1 = new Assingnment();
        assingnment1.SetStudentName("Cecilia");
        assingnment1.SetTopic("Summery of book");

        Console.WriteLine(assingnment1.GetSummery());

        MathAssignment assignament2 = new MathAssignment();
        assignament2.SetStudentName("Maria");
        assignament2.SetTopic("Fractions");
        assignament2.SetMathAssignmentInfo("Section3", "2-5");

        Console.WriteLine(assignament2.GetMathAssignmentInfo());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Peter");
        assignment3.SetTopic("Composition");
        
        Console.WriteLine(assignment3.GetWritingAssignmentInfo());
    }
}