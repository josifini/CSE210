using System;

public abstract class MindfulnessActivity
{
    protected string Name;
    protected string Description;
    protected int DurationInSeconds;

    public MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    protected void StartActivity()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);
        Console.WriteLine("Enter duration of the activity in seconds:");
        DurationInSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Countdown(5);
    }

    protected void EndActivity()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"Activity: {Name}, Duration: {DurationInSeconds} seconds");
        Countdown(3);
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}
