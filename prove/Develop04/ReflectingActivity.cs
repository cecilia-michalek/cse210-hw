using System;

public class ReflectingActivity : Activity
{

    public List<string> reflections = new List<string>
    {
        "Think of a time when you stood up for someone else",
        "Think od a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
    };
    public List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    private Random random = new();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you practice mindfulness by reflecting on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }


    public string RandomReflection()
    {
        int randomIndex = random.Next(0, reflections.Count);
        return reflections[randomIndex];
    }

    public string RandomReflectionQuestion()
    {
        int randomIndex = random.Next(0, questions.Count);
        return questions[randomIndex];
    }
    public void Run()
    {
        DisplayStartMessage();
        {
            Console.Write("Consider the following prompt...");
            Console.WriteLine(RandomReflection());
            Console.WriteLine("When you have something in mind, press Enter");
            string input = Console.ReadLine();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine(RandomReflectionQuestion());
                Spinner(5);
            }
        }
        DisplayEndMessage();
    }
}