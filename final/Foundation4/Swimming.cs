public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }
}
