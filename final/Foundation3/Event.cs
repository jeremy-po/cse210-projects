public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public virtual string GetFullDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLocation: {Address.GetFormattedAddress()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event: {Title}\nDate: {Date}";
    }
}
