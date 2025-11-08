using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference reference = new Reference("Nephi", 3, 7);

        string text = """
        And it came to pass that I, Nephi, said unto my father: 
        I will go and do the things which the Lord hath commanded, 
        for I know that the Lord giveth no commandments unto the 
        children of men, save he shall prepare a way for them that 
        they may accomplish the thing which he commandeth them.
        """;

        List<Word> words = new List<Word>();
        
        foreach (string w in text.Split(' '))
        {
            words.Add(new Word(w));
        }

        Scripture scripture = new Scripture(reference, words);

        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            int numberToHide = random.Next(1, 4);
            scripture.HideWords(numberToHide);

            if (scripture.AllHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.DisplayScripture());
                Console.WriteLine("You did it!");
                break;
            }
        }
    }
}