using System;
using System.Threading;
public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through mindful breathing. Clear you mind and focus on your breathing") { }

    public void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Please breath in slowly......");
            Countdown(5);
            Console.WriteLine("Please breath out slowly......");
            Countdown(5);
        }
        DisplayEndMessage();
    }
}