using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("Choose an activity (1-3):");

        int choice = int.Parse(Console.ReadLine());
        MindfulnessActivity activity;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            default:
                // Assuming Listing Activity is chosen
                activity = new ListingActivity();
                break;
        }

        activity.RunActivity();
    }
}
