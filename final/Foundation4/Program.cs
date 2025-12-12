using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Fitness Activity Tracker ===\n");

        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Dec 2025", 35, 4.0);
        activities.Add(running);

        Cycling cycling = new Cycling("04 Dec 2025", 45, 15.0);
        activities.Add(cycling);

        Swimming swimming = new Swimming("05 Dec 2025", 30, 20);
        activities.Add(swimming);

        Console.WriteLine("Activity Summaries:");
        Console.WriteLine("===================\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}