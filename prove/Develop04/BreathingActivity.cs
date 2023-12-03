using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();
        int elapsedTime = 0;
        while (elapsedTime < DurationInSeconds)
        {
            Console.WriteLine("Breathe in...");
            Countdown(5);
            Console.WriteLine("Breathe out...");
            Countdown(5);
            elapsedTime += 10;
        }
        EndActivity();
    }
}
