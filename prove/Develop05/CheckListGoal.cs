using System;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int count;
    private int pointsPerRecord;
    private int bonusPoints;

    public ChecklistGoal(string name, int targetCount, int pointsPerRecord, int bonusPoints) : base(name)
    {
        this.targetCount = targetCount;
        this.pointsPerRecord = pointsPerRecord;
        this.bonusPoints = bonusPoints;
        this.count = 0;
    }

    public override void RecordEvent()
    {
        if (count < targetCount)
        {
            count++;
            UpdatePoints(pointsPerRecord);

            if (count == targetCount)
            {
                UpdatePoints(bonusPoints); // Add bonus points on completion
                IsComplete = true;
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"{Name} - Completed {count}/{targetCount} times, Points per Record: {pointsPerRecord}, Bonus: {bonusPoints}, Total Points: {Points}";
    }
}
