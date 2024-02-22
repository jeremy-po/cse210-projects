public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
