using System.ComponentModel;

public class ListingActivity : Activity
{
    private List<string> _listFromUser = new List<string> ();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
    }

    private Random _random = new Random();

    public void GetRandomPrompt()
    {
        int randomIndex = _random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($" --- {randomPrompt} ---");
    }

    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.CursorVisible = true; // show cursor for simpler user interface
            string input = Console.ReadLine();
            _listFromUser.Add(input);
        }
        Console.WriteLine($"You listed {_listFromUser.Count} items!");
        Console.WriteLine();

    }


}