using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetSaveString()}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear existing entries

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split("|");
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];
                string location = parts[3];
                Entry entry = new Entry(date, prompt, entryText, location);
                _entries.Add(entry);
            }
        }
    }
}
