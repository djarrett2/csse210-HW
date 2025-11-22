public class Activity
{
    private string _activityName;
    protected int _duration;
    private string _activityDescription;

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(_activityDescription);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(4);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        Spinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}.");
        Spinner(3);
    }

    public void Spinner(int seconds)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinnerChars.Count;
        }
    }
    
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
}