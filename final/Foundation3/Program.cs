using System;

class Program
{
    static void Main()
    {
        var lecture = new Lecture(
            "C# Programming Basics", 
            "Introduction to C#", 
            new DateTime(2024, 1, 7), 
            "10 AM", 
            new Address("123 Main St", "Tech City", "NC", "USA"), 
            "John Smith", 100);

        var reception = new Reception(
            "Tech Networking Event", 
            "Meet and connect with tech professionals", 
            new DateTime(2024, 10, 15), 
            "6 PM", 
            new Address("456 Park Ave", "Tech City", "VA", "USA"), 
            "rsvp@example.com");

        var outdoorGathering = new OutdoorGathering(
            "Community Picnic", 
            "A fun day out for families", 
            new DateTime(2024, 9, 18), 
            "11 AM", 
            new Address("789 Lake Park", "Nature Town", "DC", "USA"), 
            "Sunny");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoorGathering);
    }

    static void PrintEventDetails(Event eventInstance)
    {
        Console.WriteLine(eventInstance.GetStandardDetails());
        Console.WriteLine(eventInstance.GetFullDetails());
        Console.WriteLine(eventInstance.GetShortDescription());
        Console.WriteLine("------------------------------------");
    }
}
