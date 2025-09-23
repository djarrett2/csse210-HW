using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int addNumber = -3;
        int sum = 0;
        int max = 0;
        float average;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (addNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            string userNumber = Console.ReadLine();
            addNumber = int.Parse(userNumber);

            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        Console.WriteLine(numbers.Count);

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}