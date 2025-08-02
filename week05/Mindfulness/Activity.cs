using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;     
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        Console.CursorVisible = true; // show cursor for better user interface
        string input = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        if (int.TryParse(input, out _duration))
        {

        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        Console.CursorVisible = false; // cursor to reduce flickering
        int time = 0;
        while (time < seconds)
        {
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b"); 
            Console.Write("|"); 
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b"); 
            Console.Write("-"); 
            Thread.Sleep(250);
            Console.Write("\b \b");

            time += 1;
        }

    }

    public void ShowCountDown(int seconds)
    {
        Console.CursorVisible = false; // hide cursor to reduce flickering
        int timeLeft = seconds;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(timeLeft);
            Thread.Sleep(1000);
            if (timeLeft > 9)
            {
                Console.Write("\b \b\b \b");
            }
            else
            {
                Console.Write("\b \b");
            }
            timeLeft --;
        }
    }
}