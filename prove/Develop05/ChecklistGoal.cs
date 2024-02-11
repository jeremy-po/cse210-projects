using System;

// Checklist goal class
class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int totalRequired;
    private int bonusValue;

    public ChecklistGoal(string name, int value, int totalRequired, int bonusValue) : base(name, value)
    {
        timesCompleted = 0;
        this.totalRequired = totalRequired;
        this.bonusValue = bonusValue;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for checklist goal: {Name}");
        timesCompleted++;
        if (timesCompleted >= totalRequired)
        {
            Console.WriteLine($"Bonus achieved for completing {totalRequired} times!");
            value += bonusValue;
        }
    }

    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{totalRequired} times";
    }
}
