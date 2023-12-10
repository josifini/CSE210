using System;

public abstract class Goal
{
    protected string Name;
    protected int Points;
    protected bool IsComplete;

    protected Goal(string name)
    {
        Name = name;
        IsComplete = false;
    }
    
    // Public property to access Name
    public string GoalName
    {
        get { return Name; }
    }

    // Public read-only property for Points
    public int GoalPoints
    {
        get { return Points; }
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();

    // Common method to update points
    protected void UpdatePoints(int value)
    {
        Points += value;
    }
}
