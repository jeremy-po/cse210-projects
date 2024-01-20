using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _location;  

    public Entry(string date, string promptText, string entryText, string location)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _location = location;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine();
    }

    public string GetSaveString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_location}";
    }
}
