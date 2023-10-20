using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> entries = new List<Entry>();
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

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                if (parts.Length == 3)
                {
                    string Date = parts[0];
                    string Prompt = parts[1];
                    string Response = parts[2];


                    Entry entry = new Entry(Prompt, Response, Date);
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

        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");

            }
        }

        Console.WriteLine("Entries saved.");
    }
    public void AddEntry(string prompt, string response)
    {
        DateTime date = DateTime.Now; // Get current date and time
        string dateAsString = date.ToString("yyyy-MM-dd");
        Entry entry = new Entry(prompt, response, dateAsString);
        entries.Add(entry);
        Console.WriteLine("Entry added.");
    }
}


