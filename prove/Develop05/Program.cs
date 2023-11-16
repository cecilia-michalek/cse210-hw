using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest!");
        Console.WriteLine();

        GoalManager goalManager = new GoalManager();

        string choice = "0";

        do
        {
            Console.WriteLine($"You have {goalManager._score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");

            Console.Write("Please select a choice from the menu options: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoals();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid choice.");
                    break;
            }

        } while (choice != "6");


    }
}