using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep2 World!");

       Console.WriteLine("What is your grade percentage? ");
       string inputGrade = Console.ReadLine();
        int number = int.Parse(inputGrade);

       /*if (number >= 90)
       {
        Console.WriteLine("Your grade is an A");
       }
       else if (number >= 80 && number <= 90)
       {
        Console.WriteLine("Your grade is a B");
       }
       else if (number >= 70 && number <= 80)
       {
        Console.WriteLine("Your grade is a C");
       }
       else if (number >= 60 && number <= 70)
       {
        Console.WriteLine("Your grade is a D");
       }
       else {
        Console.WriteLine("Your grade is an F");
       }*/
        string letter = "";
        
       if (number >= 90)
       {
        letter = "A";
       }
       else if (number >= 80 && number <= 90)
       {
        letter = "B";
       }
       else if (number >= 70 && number <= 80)
       {
        letter = "C";
       }
       else if (number >= 60 && number <= 70)
       {
        letter = "D";
       }
       else {
        letter = "F";
       }
            if (number >= 70){
                Console.WriteLine("You passed the class, congratulations!");
            }
            else {
                Console.WriteLine ("You did not pass the class. Keep on trying!!");
            }

    }
}