public class Running : Activity
{
    public double DistanceInMiles { get; set; }

    public override double GetDistance()
    {
        return DistanceInMiles;
    }

    public override double GetSpeed()
    {
        return DistanceInMiles / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInMiles;
    }
}
