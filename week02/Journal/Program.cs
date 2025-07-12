// to exceed the requirments, I added a feature to add or remove the available prompts so that the user can customize their experience.

using System;
using System.ComponentModel;
using System.IO;

class Program
{
    static void Main(string[] args)

    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        int input = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Edit Prompts");
            Console.Write("What would you like to do? ");
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 6)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("6. Edit Prompts");
                Console.Write("What would you like to do? ");
            }
            if (input == 1)
            {
                string prompt = promptGenerator.DisplayPrompt();
                Console.Write("> ");
                string entryText = Console.ReadLine();
                Entry entry = new Entry(
                    DateTime.Now.ToString("MM-dd-yyyy"),
                    prompt,
                    entryText
                );
                journal.AddEntry(entry);
            }
            else if (input == 2)
            {
                List<Entry> entries = journal.GetEntries();
                if (entries.Count == 0)
                {
                    Console.WriteLine("No entries to display.");
                }
                else
                {
                    foreach (Entry entry in entries)
                    {
                        entry.Display();
                    }
                }
            }
            else if (input == 3)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (input == 4)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (input == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            else if (input == 6)
            {
                string choice;
                do
                {
                    promptGenerator.ListPrompts();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Enter 1 to add a new prompt, 2 to remove a prompt, or 3 to return to the main menu.");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.Write("Enter the new prompt: ");
                        string newPrompt = Console.ReadLine();
                        promptGenerator.AddPrompt(newPrompt);
                    }
                    else if (choice == "2")
                    {
                        promptGenerator.RemovePrompt();
                    }
                    else if (choice == "3")
                    {
                        continue; // Return to the main menu
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1, 2 or 3.");
                    }
                } while (choice != "3");
                
            }

        } while (input != 5);
       
        }
}