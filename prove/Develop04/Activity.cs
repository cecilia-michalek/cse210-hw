using System;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration;
    public List<string> animationStrings = new() { "|", "/", "-", "\\" };

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;

    }

    public void Spinner(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            foreach (string symbol in animationStrings)
            {
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void Countdown(int duration)
    {
        Console.WriteLine();
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b \b\b");
        }
    }


    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n{_activityDescription}.");
        Console.Write("How long would you like to do the activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Spinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_activityName} is done!");
        Spinner(5);
    }
}