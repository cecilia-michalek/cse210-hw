using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "0";

        do {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
        
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

        
        if (choice == "1") {
            string prompt = promptGenerator.RandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine("Enter your response: ");
            string response = Console.ReadLine();
            journal.AddEntry(prompt, response);
        }
        else if (choice == "2") {
            journal.Display();
        }
        else if (choice == "3") {
            journal.LoadFile();
        }
        else if (choice == "4") {
            journal.SaveFile();
        }
        else if (choice == "5"){
            Console.WriteLine("Goodbye!"); 
        }
        else {
            Console.WriteLine("Please select a valid choice.");
        }
    }   while (choice != "5");

        
}
}

        
        
    