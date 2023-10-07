using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    public List<Entry> entries = new List<Entry>(); 

    public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}
    
    public void AddEntry(string prompt, string response)
{
    DateTime currentDate = DateTime.Now; // Get current date and time
    Entry entry = new Entry(prompt, response, currentDate);
    entries.Add(entry);
    Console.WriteLine("Entry added.");
}
    public void Display()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }
public void LoadFile()
{
    Console.Write("Enter the filename to load: ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        entries.Clear(); // Clear existing entries before loading new ones
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split(",");

            if (parts.Length == 3 &&
                    DateTime.TryParseExact(parts[0], "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime entryDate))
                {
                    string prompt = parts[1].Trim();
                    string response = parts[2].Trim();

                    Entry entry = new Entry(prompt, response, entryDate);
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Entries loaded.");
        }
            else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveFile()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}, {entry.Prompt}, {entry.Response}");
                writer.WriteLine();
            }
        }

        Console.WriteLine("Entries saved.");
    }
}

