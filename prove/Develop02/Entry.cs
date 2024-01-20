using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _entryText;
    private string _location;

    public Entry(string date, string prompt, string entryText,string location)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
        _location = location;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }

    public string GetSaveString()
    {
        return $"{_date}|{_prompt}|{_entryText}{_location}";
    }
}
