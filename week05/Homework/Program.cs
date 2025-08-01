using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("James Inskeep", "Greenhouses");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("James Inskeep", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("James Inskeep", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());


    }
}