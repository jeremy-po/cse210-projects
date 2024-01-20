using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _entryText;

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }

    public string GetSaveString()
    {
        return $"{_date}|{_prompt}|{_entryText}";
    }
}
