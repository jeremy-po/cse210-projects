using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("John:3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scripture2 = new Scripture("Proverbs:3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        DisplayScripture(scripture1);
        DisplayScripture(scripture2);
    }

    static void DisplayScripture(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim();
            if (input.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWords(2);
        }

        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}
