using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = Square(userNumber);
        DisplayResult(squaredNumber, userName);
    }

        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName() 
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
            
        }
        static int Square(int userNumber) {
            int square = userNumber * userNumber;
            return square;
        }
        static void DisplayResult(int square, string name) 
        {
    
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
}
