public class Cycling : Activity
{
    public double SpeedInMph { get; set; }

    public override double GetDistance()
    {
        return SpeedInMph * (DurationInMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetPace()
    {
        return 60 / SpeedInMph;
    }
}
