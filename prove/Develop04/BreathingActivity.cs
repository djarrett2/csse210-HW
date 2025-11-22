public class Breathing : Activity
{
    //private int _breatheDuration;

    public Breathing() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Countdown(5);
            
            if (DateTime.Now >= endTime) break;
            
            Console.Write("\nNow breathe out...");
            Countdown(5);
        }
    }
}