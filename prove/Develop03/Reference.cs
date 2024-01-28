class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(':', '-');

        _book = parts[0].Trim();
        _chapter = int.Parse(parts[1].Trim());
        _verse = int.Parse(parts[2].Trim());

        if (parts.Length == 4)
        {
            _endVerse = int.Parse(parts[3].Trim());
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_verse}";
    }
}
