using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to Goal Tracker!");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event for a goal");
            Console.WriteLine("3. Display progress");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayProgress();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter value for completing the goal: ");
        int value = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, value));
                Console.WriteLine("Simple goal created.");
                break;
            case "2":
                goals.Add(new EternalGoal(name, value));
                Console.WriteLine("Eternal goal created.");
                break;
            case "3":
                Console.Write("Enter total required times for checklist goal: ");
                int totalRequired = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus value for checklist goal: ");
                int bonusValue = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, totalRequired, bonusValue));
                Console.WriteLine("Checklist goal created.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Select a goal to record event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        goals[goalIndex].RecordEvent();
    }

    static void DisplayProgress()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Goal Progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}: {goals[i].GetProgress()}");
        }
    }
}