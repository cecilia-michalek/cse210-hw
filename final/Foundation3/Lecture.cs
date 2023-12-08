using System;
public class Lecture : Event
{
    protected string _speaker;
    protected  int _capacity;

    public Lecture(string eventType, string eventTitle, string eventDescription, DateTime date, int time, Address address, string speaker, int capacity) : base(eventType, eventTitle, eventDescription, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public void Activity()
    {
        Console.WriteLine();
        GetDetails(EventMessageType.Standard);
        Console.WriteLine();
        GetDetails(EventMessageType.Full);
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
        GetDetails(EventMessageType.Short);
    }
}