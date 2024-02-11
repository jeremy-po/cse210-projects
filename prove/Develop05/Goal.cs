using System;

// Base class for goals
abstract class Goal
{
    public string Name { get; private set; }
    protected int value;

    public Goal(string name, int value)
    {
        Name = name;
        this.value = value;
    }

    public abstract void RecordEvent();

    public abstract string GetProgress();
}
