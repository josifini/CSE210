using System;

public class Lecture : Event
{
    public string Speaker { get; private set; }
    public int Capacity { get; private set; }

    public Lecture(string title, string description, DateTime date, string time, Address eventAddress, string speaker, int capacity)
        : base(title, description, date, time, eventAddress)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}, Speaker: {Speaker}, Capacity: {Capacity}";
    }
}
