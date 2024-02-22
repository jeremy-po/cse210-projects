using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = "07 Jan 2024", DurationInMinutes = 45, DistanceInMiles = 4.0 },
            new Cycling { Date = "08 Jan 2024", DurationInMinutes = 60, SpeedInMph = 10 },
            new Swimming { Date = "09 Jan 2024", DurationInMinutes = 30, Laps = 25 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
