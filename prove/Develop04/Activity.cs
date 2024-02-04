class Activity
{
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        int duration = GetDuration();
        Console.WriteLine($"Starting {name} activity with duration {duration} seconds...");
        Console.WriteLine(description);
        Console.WriteLine("Prepare to begin...");
        PerformCountdown(duration);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You've completed the {name} activity.");
        Console.WriteLine("Pausing before finishing...");
        PerformCountdown(3);
    }

    protected virtual int GetDuration()
    {
        Console.Write($"Enter duration for {name} activity (in seconds): ");
        return Convert.ToInt32(Console.ReadLine());
    }

    protected void PerformCountdown(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}