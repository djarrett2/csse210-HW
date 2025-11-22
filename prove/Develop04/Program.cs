using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing();
                    breathing.DisplayStartMessage();
                    breathing.RunActivity();
                    breathing.DisplayEndMessage();
                    break;
                case "2":
                    Reflection reflection = new Reflection();
                    reflection.DisplayStartMessage();
                    reflection.RunActivity();
                    reflection.DisplayEndMessage();
                    break;
                case "3":
                    Listing listing = new Listing();
                    listing.DisplayStartMessage();
                    listing.RunActivity();
                    listing.DisplayEndMessage();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    continue;
            }
        }

    }
}