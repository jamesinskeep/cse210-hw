public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nCurrent Score: {_score}\n");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a  choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Total Goals: {_goals.Count}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Goal goal = null;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
        string type = Console.ReadLine();
        string shortName = "";
        string description = "";
        string points = "";
        int target = 0;
        int bonus = 0;

        switch (type)
        {
            case "1":
                Console.Write("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                description = Console.ReadLine();
                while (true)
                {
                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    if (int.TryParse(points, out int parsedPoints) && parsedPoints > 0)
                    {
                        points = parsedPoints.ToString();
                        goal = new SimpleGoal(shortName, description, points);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid points input. Please enter a positive integer.");
                    }
                }
                break;

            case "2":
                Console.Write("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                description = Console.ReadLine();
                while (true)
                {
                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    if (int.TryParse(points, out int parsedPoints) && parsedPoints > 0)
                    {
                        points = parsedPoints.ToString();
                        goal = new EternalGoal(shortName, description, points);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid points input. Please enter a positive integer.");
                    }
                }
                break;
            case "3":
                Console.Write("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                description = Console.ReadLine();
                while (true)
                {
                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    if (int.TryParse(points, out int parsedPoints) && parsedPoints > 0)
                    {
                        points = parsedPoints.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid points input. Please enter a positive integer.");
                    }
                }
                while (true)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string targetInput = Console.ReadLine();
                    if (int.TryParse(targetInput, out int parsedTarget) && parsedTarget > 0)
                    {
                        target = parsedTarget;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid target input. Please enter a positive integer.");
                    }
                }
                while (true)
                {
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonusInput = Console.ReadLine();
                    if (int.TryParse(bonusInput, out int parsedBonus) && parsedBonus > 0)
                    {
                        bonus = parsedBonus;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid bonus input. Please enter a positive integer.");
                    }
                }
                goal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
        _goals.Add(goal);
        Console.WriteLine($"Goal '{shortName}' added successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal number to record an event:");
        ListGoalNames();
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            var goal = _goals[goalIndex - 1];
            goal.RecordEvent();
            int pointsEarned = int.Parse(goal.GetPoints());
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filePath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filePath = Console.ReadLine();
        _goals.Clear(); // Clear existing goals before loading
        _score = 0; // Reset score when loading new goals

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Cannot load goals.");
            return;
        }
        using (StreamReader reader = new StreamReader(filePath))
        {
            // first line is the score
            string scoreLine = reader.ReadLine();
            if (int.TryParse(scoreLine, out int score))
            {
                _score = score;
            }

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(",");
                if (parts.Length < 4) continue; // Skip invalid lines
                string type = parts[0].ToLower();
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];

                try
                {
                    if (type.Contains("simple"))
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        var goal = new SimpleGoal(shortName, description, points);
                        if (isComplete)
                        {
                            goal.RecordEvent(); // this will set completion state
                        }
                        _goals.Add(goal);
                    }
                    else if (type.Contains("checklist"))
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        int amountCompleted = int.Parse(parts[5]);
                        int target = int.Parse(parts[6]);   // Assuming target is the 5th part
                        int bonus = int.Parse(parts[7]);    // Assuming bonus is the 6th part
                        var goal = new ChecklistGoal(shortName, description, points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++)
                        {
                            goal.RecordEvent(); // Record the event for each completed amount
                        }
                        _goals.Add(goal);
                    }
                    else if (type.Contains("eternal"))
                    {
                        _goals.Add(new EternalGoal(shortName, description, points));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading goal: {ex.Message}");
                }

            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}