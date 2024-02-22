public abstract class Activity
{
    public string Date { get; set; }
    public int DurationInMinutes { get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
    double roundedSpeed = Math.Round(GetSpeed(), 1);
    return $"{Date} {GetType().Name} ({DurationInMinutes} mins) - Distance: {GetDistance()} MILES, Speed: {roundedSpeed} MPH, Pace: {GetPace()}";
    }

}
