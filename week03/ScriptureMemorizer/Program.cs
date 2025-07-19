using System;
// Exceeding requirements:
// Added a menu class to select from a library of scriptures.
// The menu allows the user to select a scripture by number.
class Program
{
    static void Main(string[] args)
    {
        // display menu
        Menu menu = new Menu();
        menu.DisplayMenu();

        // import reference and scripture from menu
        Scripture scripture = menu.SelectScripture();

        // Display the reference and scripture text.        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // display message to user : Enter to hide words, quit to exit.
        Console.WriteLine("Press Enter to hide random words, or type 'quit' to exit.");
        string input = "";
        while (scripture.IsCompletelyHidden() == false)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the Scripture Memorizer.");
                break;
            }
            // Hide random words in the scripture.
            Random random = new Random();
            // Hide a random number of words between 2 and 5.
            scripture.HideRandomWords(random.Next(2, 6));
            // clear the console and reprint with hidden words.
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");

        }
    }
}