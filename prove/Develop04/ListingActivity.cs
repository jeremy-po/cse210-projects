using System;
using System.Threading;

class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void PerformListing(int duration)
    {
        StartActivity();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        Console.WriteLine("You have " + duration + " seconds to list as many items as you can.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Item " + (itemCount + 1) + ": ");
            string input = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine("You listed " + itemCount + " items.");

        EndActivity();
    }

    private string GetRandomPrompt()
    {
        return "Who are people that you appreciate?";
    }
}
