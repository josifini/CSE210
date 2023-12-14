using System;

public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50.0 / 1000; // Distance in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // Pace in min per km
    }
}
