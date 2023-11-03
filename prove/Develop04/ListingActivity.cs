using System;

public class ListingActivity : Activity
{

    private List<string> listOfQuestions = new List<string>
    {
        "Make a list of attributes you think you have",
        "Make a list of good things that happen to you today",
        "Make a list of times you felt the Spirit this week",
        "Make a list of good things you did for other today",
        };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public string RandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, listOfQuestions.Count);
        return listOfQuestions[randomIndex];
    }

    public void Run()
    {
        DisplayStartMessage();
        {
            Console.Write("Consider the following question...");
            Console.WriteLine(RandomPrompt());
            int counter = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string answer = Console.ReadLine();
                counter++;
                Console.Write($"You listed {counter} thoughts");

                Spinner(10);
            }
        }
        DisplayEndMessage();
    }
}

