using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        // Creating different types of goals
        Goal simpleGoal = new SimpleGoal("Graduate In April", 1000);
        Goal eternalGoal = new EternalGoal("Read Daily", 100);
        Goal checklistGoal = new ChecklistGoal("Attend Gym", 10, 50, 500);

        // Adding goals to the manager
        manager.AddGoal(simpleGoal);
        manager.AddGoal(eternalGoal);
        manager.AddGoal(checklistGoal);

        // Simulating recording some events
        manager.RecordGoalEvent("Read Daily");
        manager.RecordGoalEvent("Attend Gym");
        manager.RecordGoalEvent("Graduate In April");

        // Displaying all goals
        manager.DisplayGoals();

        // Display total score
        Console.WriteLine($"Total Score: {manager.GetTotalScore()}");
    }
}
