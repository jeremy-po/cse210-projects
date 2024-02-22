using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture
        {
            Title = "Introduction to Auto Mechanics",
            Description = "Learn about the inner workings of vehicles.",
            Date = "February 20, 2024",
            Time = "10:00 AM",
            Address = new Address { Street = "123 La Puerta St", City = "Doral", StateProvince = "FL", Country = "USA" },
            Speaker = "Mr. Smith",
            Capacity = 100
        };

        Reception reception = new Reception
        {
            Title = "Company Anniversary Celebration",
            Description = "Join us for an evening of celebration and networking.",
            Date = "February 15, 2024",
            Time = "7:00 PM",
            Address = new Address { Street = "42 Wallaby St", City = "Sydney", StateProvince = "AB", Country = "Australia" },
            RsvpEmail = "event@example.com"
        };

        OutdoorGathering gathering = new OutdoorGathering
        {
            Title = "Beach Picnic",
            Description = "Enjoy a day of fun and games at our annual beach picnic.",
            Date = "July 10, 2024",
            Time = "11:00 AM",
            Address = new Address { Street = "17 Beach St", City = "Scarborough", StateProvince = "TB", Country = "Tobago" },
            WeatherForecast = "Sunny"
        };

        Console.WriteLine("Event Details:");
        Console.WriteLine("----------------");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(gathering.GetFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine("----------------");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(gathering.GetShortDescription());
    }
}
