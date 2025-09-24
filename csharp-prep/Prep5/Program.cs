using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int UserNumber = int.Parse(input);
        return UserNumber;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string getYear = Console.ReadLine();
        int year = int.Parse(getYear);
        return year;
    }
    static int SquareNumber(int x)
    {
        return x * x;
    }
    static void DisplayResult(string name, int number, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber, birthYear);
    }
}