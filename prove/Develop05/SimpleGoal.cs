using System;

// Simple goal class
class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int value) : base(name, value)
    {
        completed = false;
    }

    public override void RecordEvent()
    {
        if (!completed)
        {
            Console.WriteLine($"Completed goal: {Name}");
            completed = true;
        }
        else
        {
            Console.WriteLine($"Goal {Name} already completed.");
        }
    }

    public override string GetProgress()
    {
        return completed ? "[X]" : "[ ]";
    }
}
