public class ReflectingActivity : Activity
{
    private int _pause = 5; // time in seconds to display new questions
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base(
       "Reflecting Activity",
       "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
       0)
    {
    }

    private Random _random = new Random();

    private string GetRandomPrompt()
    {
        int randomIndex = _random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.CursorVisible = true; // show cursor for user interface
        Console.ReadLine();
    }

    private string GetRandomQuestion()
    {
        int randomIndex = _random.Next(0, _questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }

    private void DisplayRandomQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(_pause);
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int time = 0;
        while (time < _duration)
        {
            DisplayRandomQuestion();
            time += _pause;
        }

    }

}