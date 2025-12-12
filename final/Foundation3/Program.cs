using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Event Management System ===\n");

        Address lectureAddress = new Address("639 University Ave", "Boston", "MA", "USA");
        Lectures lecture = new Lectures("The Future of Artificial Intelligence" , "Join us for an insightful discussion on AI trends and their impact on society." , "January 15, 2025" , "7:00 PM" , lectureAddress , "Dr. Jane Martinez" , 100);

        Address receptionAddress = new Address("428 Grand Ballroom", "New York", "NY", "USA");
        Receptions reception = new Receptions("Annual Charity Gala" , "An elegant evening supporting local education initiatives." , "February 20, 2025" , "6:30 PM" , receptionAddress , "rsvp@charitygala.org");

        Address outdoorAddress = new Address("1751 Park Plaza", "Seattle", "WA", "USA");
        OutdoorGatherings outdoor = new OutdoorGatherings("Summer Music Festival" , "A day of live music featuring local and international artists." , "July 4, 2025" , "12:00 PM" , outdoorAddress , "Sunny, 75°F");

        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine("=============");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetDescription());
        Console.WriteLine("\n");

        Console.WriteLine("RECEPTION EVENT");
        Console.WriteLine("===============");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetDescription());
        Console.WriteLine("\n");

        Console.WriteLine("OUTDOOR GATHERING EVENT");
        Console.WriteLine("=======================");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoor.GetDescription());
    }
}