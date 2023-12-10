using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        this.Points = points;
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            UpdatePoints(Points); // Add points to the goal
            IsComplete = true; // Mark as complete
        }
    }

    public override string GetDetailsString()
    {
        return $"{Name} - Completed: {(IsComplete ? "[X]" : "[ ]")}, Points: {Points}";
    }
}
