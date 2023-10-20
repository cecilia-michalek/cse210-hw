using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("Welcome to the Scripture Program!");

        //string reference = "Proverbs 3:5-6";
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.";
        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;

        Reference ScriptureReference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(ScriptureReference, text);

        string userInput;

        //while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Would you like to memorize your own scripture or the scripture provided?");
            Console.WriteLine("If you want to enter your own scripture, press '1'.");
            Console.WriteLine("If you want to use a random scripture, press '2'.");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Prompt the user for their own scripture
                Console.Write("Enter the book: ");
                string userBook = Console.ReadLine();

                Console.Write("Enter the chapter: ");
                int userChapter = int.Parse(Console.ReadLine());

                Console.Write("Enter the starting verse: ");
                int userStartVerse = int.Parse(Console.ReadLine());

                Console.Write("Enter the ending verse (0 for single verse): ");
                int userEndVerse = int.Parse(Console.ReadLine());

                Console.Write("Enter the scripture text: ");
                string userText = Console.ReadLine();

                Reference userReference = new Reference(userBook, userChapter, userStartVerse, userEndVerse);
                Scripture userScripture = new Scripture(userReference, userText);

                while (true)
                {
                    Console.Clear();
                    userScripture.Display();

                    Console.WriteLine("Press 'enter' to continue or type 'quit' to exit: ");
                    string input = Console.ReadLine();
                    if (userScripture.AllWordsHidden())
                        break;
                    else if (input == "quit")
                        break;

                    int counter = 0;
                    while (counter < 3 && !userScripture.AllWordsHidden())
                    {
                        userScripture.HideRandomWord();
                        counter++;
                    }
                }
            }
            else if (userInput == "2")
            {
                while (true)
                {
                    Console.Clear();
                    scripture.Display();

                    Console.WriteLine("Press 'enter' to continue or type 'quit' to exit: ");
                    string input = Console.ReadLine();
                    if (scripture.AllWordsHidden())
                        break;
                    else if (input == "quit")
                        break;

                    int counter = 0;
                    while (counter < 3 && !scripture.AllWordsHidden())
                    {
                        scripture.HideRandomWord();
                        counter++;
                    }
                }
            }
        }
        
    }
}