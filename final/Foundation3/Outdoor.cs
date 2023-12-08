using System;
public class Outdoor : Event
{
    protected string _weather;
    public Outdoor(string eventType, string eventTitle, string eventDescription, DateTime date, int time, Address address, string weather) : base(eventType, eventTitle, eventDescription, date, time, address)
    {
        _weather = weather;
    }
    public void Activity()
    {
        Console.WriteLine();
        GetDetails(EventMessageType.Standard);
        Console.WriteLine();
        GetDetails(EventMessageType.Full);
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
        GetDetails(EventMessageType.Short);
    }
}