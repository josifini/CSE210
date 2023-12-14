using System;

public class Reception : Event
{
    public string RSVP_Email { get; private set; }

    public Reception(string title, string description, DateTime date, string time, Address eventAddress, string rsvpEmail)
        : base(title, description, date, time, eventAddress)
    {
        RSVP_Email = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}, RSVP at: {RSVP_Email}";
    }
}
