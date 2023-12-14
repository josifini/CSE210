using System;

public abstract class Activity
{
    public DateTime Date { get; private set; }
    public int DurationInMinutes { get; private set; }

    protected Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation, to be overridden
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, to be overridden
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, to be overridden
    }

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({DurationInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
