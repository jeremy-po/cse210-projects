public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {RsvpEmail}";
    }
}
