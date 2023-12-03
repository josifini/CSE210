using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = new string[]
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        // ... Additional logic for questions ...
        EndActivity();
    }
}
