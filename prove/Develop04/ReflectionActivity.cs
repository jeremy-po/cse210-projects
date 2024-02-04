
class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void PerformReflection()
    {
        StartActivity();
        Console.WriteLine("Let's begin the reflection activity...");
        Console.WriteLine();

        
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        
        Shuffle(questions, random);

        
        foreach (string question in questions)
        {
            Console.WriteLine();
            Console.WriteLine(question);
            SpinnerAnimation();
            Console.WriteLine();
        }

        EndActivity();
    }

    
    private void Shuffle(string[] array, Random random)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    
    private void SpinnerAnimation()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\r{spinner[index]}");
            System.Threading.Thread.Sleep(200);
            index = (index + 1) % spinner.Length;
        }
    }
}