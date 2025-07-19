using System.Xml.Serialization;

public class Menu
{
    private Reference _reference1;
    private Scripture _scripture1;
    private Reference _reference2;
    private Scripture _scripture2;
    private Reference _reference3;
    private Scripture _scripture3;
    private Reference _reference4;
    private Scripture _scripture4;
    private Reference _reference5;
    private Scripture _scripture5;
    private Reference _reference6;
    private Scripture _scripture6;
    private Reference _reference7;
    private Scripture _scripture7;

    public Menu()
    {
        _reference1 = new Reference("John", 3, 16);
        _scripture1 = new Scripture(_reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _reference2 = new Reference("1 Nephi", 3, 7);
        _scripture2 = new Scripture(_reference2, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        _reference3 = new Reference("Proverbs", 3, 5, 6);
        _scripture3 = new Scripture(_reference3, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        _reference4 = new Reference("Moses", 7, 18);
        _scripture4 = new Scripture(_reference4, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        _reference5 = new Reference("Isaiah", 53, 3, 5);
        _scripture5 = new Scripture(_reference5, "He is despised and rejected of men; a man of sorrows, and acquainted with grief: and we hid as it were our faces from him; he was despised, and we esteemed him not. Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed.");
        _reference6 = new Reference("Matthew", 5, 14, 16);
        _scripture6 = new Scripture(_reference6, "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        _reference7 = new Reference("Doctrine & Covenants", 6, 36);
        _scripture7 = new Scripture(_reference7, "Look unto me in every thought; doubt not, fear not.");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Please choose a scripture to memorize:");

        Console.WriteLine($"1. {_reference1.GetDisplayText()}");
        Console.WriteLine($"2. {_reference2.GetDisplayText()}");
        Console.WriteLine($"3. {_reference3.GetDisplayText()}");
        Console.WriteLine($"4. {_reference4.GetDisplayText()}");
        Console.WriteLine($"5. {_reference5.GetDisplayText()}");
        Console.WriteLine($"6. {_reference6.GetDisplayText()}");
        Console.WriteLine($"7. {_reference7.GetDisplayText()}");
    }
    public Scripture SelectScripture()
    {
        while (true)
        {
            Console.WriteLine("Enter the number of the scripture you want to memorize (1-7):");
            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 7)
            {
                if (choice == 1) { return _scripture1; }
                if (choice == 2) { return _scripture2; }
                if (choice == 3) { return _scripture3; }
                if (choice == 4) { return _scripture4; }
                if (choice == 5) { return _scripture5; }
                if (choice == 6) { return _scripture6; }
                if (choice == 7) { return _scripture7; }
            }

            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }

        }
    }
}
