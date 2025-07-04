using System;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber = 0;
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guessNumber != magicNumber);
    }
}


