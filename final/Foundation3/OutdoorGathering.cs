public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather Forecast: {WeatherForecast}";
    }
}
