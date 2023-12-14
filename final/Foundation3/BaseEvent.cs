using System;

public class Event
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public string Time { get; private set; }
    public Address EventAddress { get; private set; }

    public Event(string title, string description, DateTime date, string time, Address eventAddress)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = eventAddress;
    }

    public virtual string GetStandardDetails()
    {
        return $"{Title}: {Description}, on {Date.ToShortDateString()} at {Time}, Location: {EventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"{Title}, on {Date.ToShortDateString()}";
    }
}
