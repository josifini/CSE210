using System;

public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    // Method to add a new goal
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    // Method to record an event for a specific goal
    public void RecordGoalEvent(string goalName)
    {
        var goal = goals.FirstOrDefault(g => g.GoalName == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            totalScore += goal.GoalPoints;
        }
    }

    // Method to display all goals
    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Method to get the total score
    public int GetTotalScore()
    {
        return totalScore;
    }

    // Add other methods for saving and loading goals if necessary
}
