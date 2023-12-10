using System;

public class EternalGoal : Goal
{
    private int pointsPerRecord;

    public EternalGoal(string name, int pointsPerRecord) : base(name)
    {
        this.pointsPerRecord = pointsPerRecord;
    }

    public override void RecordEvent()
    {
        UpdatePoints(pointsPerRecord); // Add points each time the event is recorded
    }

    public override string GetDetailsString()
    {
        return $"{Name} - Eternal, Points per Record: {pointsPerRecord}, Total Points: {Points}";
    }
}
