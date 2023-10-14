using System;
using System.Collections.Generic;
using System.IO;


public class PromptGenerator
{

    public List<string> prompts;
    private Random random;
    public PromptGenerator()
    {


        prompts = new List<string>
    {
        "What was one act of kindness I did today?",
        "What was a part of my day I want to remember?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

        random = new Random();
    }
    public string RandomPrompt()
    {

        int randomIndex = random.Next(0, prompts.Count);
        return prompts[randomIndex];
    }
}



