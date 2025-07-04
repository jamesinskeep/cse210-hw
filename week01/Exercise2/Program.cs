using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercetage = int.Parse(gradePercentageInput);
        string letter = "";
        if (gradePercetage >= 90)
        {
            letter = "A"; 
        }
        else if (gradePercetage >= 80)
        {
            letter = "B";
        }
        else if (gradePercetage >= 70)
        {
            letter = "C";
        }
        else if (gradePercetage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }       
        Console.WriteLine($"Your letter grade is {letter}.");
        if (gradePercetage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course, but you can take it again for a better grade.");
        }   
    }
}