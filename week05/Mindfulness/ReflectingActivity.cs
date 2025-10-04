public class ReflectingActivity : Activity
{
    private List<string> _prompts = [
        "think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    private static readonly Random _random = new Random();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        name = _name;
        description = _description;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Consider the following prompt:\n\n ---{prompt}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> nonRepeatList = new List<string>(_questions);
        while (DateTime.Now < endTime)
        {
            int questionIndex = _random.Next(nonRepeatList.Count);
            Console.Write($"{nonRepeatList[questionIndex]} ");
            nonRepeatList.RemoveAt(questionIndex);
            ShowSpinner(10);
            Console.WriteLine("");
        }
        DisplayEndingMessage();
    }
}