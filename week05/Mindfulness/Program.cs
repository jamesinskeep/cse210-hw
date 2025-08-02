using System;

// for added functionality, I hid the cursor during animations for clearer animations
// and made cursor visible when input is required
// added animation in Breathing Activity to help with visualization
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            menu.DisplayMenu();
            Console.CursorVisible = true; // display cursor for better user interface
            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
            {
                if (choice == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                }
                if (choice == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                }
                if (choice == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                }
                if (choice == 4)
                {
                    Console.WriteLine("You have selected to Quit");
                    break;
                }
            }

            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Thread.Sleep(750);
            }

        }
    }
}