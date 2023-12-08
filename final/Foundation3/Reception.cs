using System;
public class Reception : Event
{
    protected string _rsvpEmail;
    public Reception(string eventType, string eventTitle, string eventDescription, DateTime date, int time, Address address, string rsvpEmail) : base(eventType, eventTitle, eventDescription, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public void Activity()
    {
        Console.WriteLine();
        GetDetails(EventMessageType.Standard);
        Console.WriteLine();
        GetDetails(EventMessageType.Full);
        Console.WriteLine($"RSVP: {_rsvpEmail}");
        Console.WriteLine();
        GetDetails(EventMessageType.Short);
    }

}