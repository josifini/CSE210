using System;

public class Cycling : Activity
{
    public double Speed { get; private set; } // in kph

    public Cycling(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * DurationInMinutes) / 60; // Distance in km
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed; // Pace in min per km
    }
}
