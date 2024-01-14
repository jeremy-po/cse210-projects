using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Take input until the user enters 0
        while (true)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        // Compute sum, average, and find the maximum
        int sum = 0;
        double average = 0;
        int max = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
