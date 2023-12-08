using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running(DateTime.Now, 30, 4.0);
        Cycling cyclingActivity = new Cycling(DateTime.Now, 60, 10);
        Swimming swimmingActivity = new Swimming(DateTime.Now, 40, 15);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}