using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void PerformBreathing(int duration)
    {
        StartActivity();
        Console.WriteLine("Let's begin the breathing exercise...");

        int numberOfCycles = duration / 6; 
        int remainingTime = duration % 6; 

        for (int i = 0; i < numberOfCycles; i++)
        {
            BreatheIn();
            BreatheOut();
        }

       
        if (remainingTime > 0)
        {
            
            int remainingCycles = (int)Math.Ceiling((double)remainingTime / 3);

            for (int i = 0; i < remainingCycles; i++)
            {
                BreatheIn();
                BreatheOut();
            }
        }

        EndActivity();
    }

    private void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(3000); 
    }

    private void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        Thread.Sleep(3000); 
    }
}
