public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private static readonly Random _random = new Random();

    public ListingActivity(string name, string description) : base(name, description)
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
        Console.WriteLine($"List as many responses you can to the following prompt:\n ---{prompt}---");
        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
            Console.Write("");
        }
        Console.WriteLine($"You listed {_count} items!\n");
        DisplayEndingMessage();
    }
}
