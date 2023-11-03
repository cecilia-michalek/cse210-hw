using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string choice = "0";

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Please select a choice from the menu options: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity activityBreathing = new BreathingActivity();
                    activityBreathing.Run();
                    break;
                case "2":
                    ReflectingActivity activityReflecting = new ReflectingActivity();
                    activityReflecting.Run();
                    break;
                case "3":
                    ListingActivity activityListing = new ListingActivity();
                    activityListing.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid choice.");
                    break;
            }

        } while (choice != "4");


    }
}





