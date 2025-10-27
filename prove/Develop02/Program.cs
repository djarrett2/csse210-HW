using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;

        while (run)
        {
            Console.WriteLine("Welcome to teh Journal Program: ");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.NewEntry();
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    journal.Load();
                    break;
                case "4":
                    journal.Save();
                    break;
                case "5":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Wrong input, try again.");
                    break;
            }
        }
    }
}