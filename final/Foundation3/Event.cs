using System;

public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _eventDescription;
    protected DateTime _date;
    protected int _time;
    protected Address _address;
    public Event(string eventType, string eventTitle, string eventDescription, DateTime date, int time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _time = time;
        _address = address;
    }
    public enum EventMessageType
    {
        Standard,
        Full,
        Short
    }
    public void GetDetails(EventMessageType messageType)
    {
        switch (messageType)
        {
            case EventMessageType.Standard:
                Console.WriteLine($"Event Title: {_eventTitle}");
                Console.WriteLine($"Date: {_date.ToShortDateString()}");
                Console.WriteLine($"Time: {_time}");
                Console.WriteLine($"Address: {_address.GetFullAddress()}");
                break;
            case EventMessageType.Full:
                Console.WriteLine($"Event Type: {_eventType}");
                Console.WriteLine($"Event Title: {_eventTitle}");
                Console.WriteLine($"Event Description: {_eventDescription}");
                Console.WriteLine($"Date: {_date.ToShortDateString()}");
                Console.WriteLine($"Time: {_time}hs.");
                Console.WriteLine($"Address: {_address.GetFullAddress()}");
                break;
            case EventMessageType.Short:
                Console.WriteLine($"Event Type: {_eventType}");
                Console.WriteLine($"Event Title: {_eventTitle}");
                Console.WriteLine($"Date: {_date.ToShortDateString()}");
                break;
            default:
                Console.WriteLine("Invalid Message");
                break;
        }
    }
    /*public void GetStandardDetails()
    {
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Event Description: {_eventDescription}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");

    }
    public void GetFullDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        GetStandardDetails();

    }
    public void GetShortDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");

    }*/

}