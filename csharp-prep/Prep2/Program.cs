using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        char letter = ' ';

        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine($"You didn't pass this time, but you can do better next time.");
        }


        Console.WriteLine($"Your final grade is: {letter}");
    }
}
