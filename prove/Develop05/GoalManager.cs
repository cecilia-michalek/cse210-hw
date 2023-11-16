using System;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You now have {_score} points.");

    }
    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{i + 1}.{_goals[i].GetStringRepresentation()} {_goals[i].GetGoalName()} ,{_goals[i].GetDetailsString()}, {_goals[i].GetPoints()}, {_goals[i].IsComplete()}");

        }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.Write($"{goal.GetDetailsString()}");
        }
    }
    public void CreateGoals()
    {
        Console.WriteLine("Select a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of the goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associeted with this goal? ");
        int point = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(goalType, shortName, goalDescription, point, false);
                break;
            case "2":
                newGoal = new EternalGoal(goalType, shortName, goalDescription, point);
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the checklist goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalType, shortName, goalDescription, point, targetCount, bonusPoints, false);
                break;
            default:
                Console.WriteLine("Invalid goal type choice.");
                return;
        }

        AddGoal(newGoal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you acomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalIndex--;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                _goals[goalIndex].RecordEvent();
                _score += _goals[goalIndex].GetPoints() + (_goals[goalIndex] is ChecklistGoal ? ((ChecklistGoal)_goals[goalIndex]).GetBonusPoints() : 0);

                if (_goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    Console.WriteLine($"Congratulations! You have achieved the {checklistGoal.GetGoalName()} goal and earned {checklistGoal.GetBonusPoints()} bonus points!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You have earned {_score} points!");
                }

                DisplayPlayerInfo();

            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetGoalType()}: {goal.GetGoalName()}, {goal.GetDetailsString()}, {goal.GetPoints()}, {goal.IsComplete()}");
            }
        }

        Console.WriteLine("Goals saved.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                if (parts.Length >= 5)
                {
                    string goalType = parts[0];
                    string shortName = parts[1];
                    string goalDescription = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);



                    Goal loadedGoal = null;
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            loadedGoal = new SimpleGoal(goalType, shortName, goalDescription, points, isComplete);
                            break;
                        case "EternalGoal":
                            loadedGoal = new EternalGoal(goalType, shortName, goalDescription, points);
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            loadedGoal = new ChecklistGoal(goalType, shortName, goalDescription, points, targetCount, bonusPoints, isComplete);
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }

                    if (loadedGoal != null)
                    {
                        loadedGoal.IsComplete();
                        _goals.Add(loadedGoal);
                    }
                }
            }

            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

