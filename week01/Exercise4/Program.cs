using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }
        int total = 0;
        int largest = numbers[0];
        foreach (int num in numbers)
        {
            total += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        double average = (double)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}