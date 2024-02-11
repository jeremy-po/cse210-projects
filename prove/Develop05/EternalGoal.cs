using System;

// Eternal goal class
class EternalGoal : Goal
{
    private int timesCompleted;

    public EternalGoal(string name, int value) : base(name, value)
    {
        timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for eternal goal: {Name}");
        timesCompleted++;
    }

    public override string GetProgress()
    {
        return $"Completed {timesCompleted} times";
    }
}
