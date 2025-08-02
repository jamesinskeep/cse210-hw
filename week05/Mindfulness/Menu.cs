using System.Xml.Serialization;

public class Menu
{

    public Menu()
    {

    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");

        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");


    }
}
