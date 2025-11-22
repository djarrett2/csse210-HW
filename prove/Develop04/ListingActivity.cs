public class Listing : Activity
{
    private List<string> _prompts;
    private Random _random = new Random();
    private int _count;

    public Listing() : base("Activity description",
"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public void RunActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _count++;
            }
        }
        
        Console.WriteLine($"You listed {_count} items!");
    }

}