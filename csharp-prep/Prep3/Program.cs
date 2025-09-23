using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 650;

        Random randomGenerator = new Random();
        int magNumber = randomGenerator.Next(1, 100);

        while (guess != magNumber)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > magNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}