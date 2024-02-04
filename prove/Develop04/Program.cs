using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 4)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter duration for Breathing activity (in seconds): ");
                    int breathingDuration = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.PerformBreathing(breathingDuration);
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.PerformReflection();
                    break;
                case 3:
                    int listingDuration;
                    do
                    {
                        Console.Write("Enter duration for Listing activity (in seconds): ");
                    } while (!int.TryParse(Console.ReadLine(), out listingDuration));
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.PerformListing(listingDuration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
