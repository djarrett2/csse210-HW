using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bob Jones", "Physics");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Tony Mark", "Fractions", "5.6", "4-15");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Mary Lamb", "US History", "Great generals of the Civil War");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}