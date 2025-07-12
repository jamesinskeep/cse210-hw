using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who did I see represent Jesus Christ today?"
    };

    private Random _random = new Random();

    public string DisplayPrompt()
    {
        if (_prompts.Count > 0)
        {
            int randomIndex = _random.Next(0, _prompts.Count);
            string randomPrompt = _prompts[randomIndex];
            Console.WriteLine(randomPrompt);
            return randomPrompt;
        }
        else
        {
            Console.WriteLine("No prompts available.");
            return string.Empty;
        }
    }
    public void ListPrompts()
    {
        if (_prompts.Count > 0)
        {
            Console.WriteLine("Available prompts:");
            for (int i = 0; i < _prompts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_prompts[i]}");
            }
        }
        else
        {
            Console.WriteLine("No prompts available.");
        }
    }
    public void AddPrompt(string prompt)
    {
            _prompts.Add(prompt);
    }
    public void RemovePrompt()
    {
        Console.Write("Enter the number of the prompt you would like to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _prompts.Count)
        _prompts.RemoveAt(index-1);
    }
      
}