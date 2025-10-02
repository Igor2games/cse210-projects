public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        name = _name;
        description = _description;
    }

    public string GetName()
    {
        return _name;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Now Breath out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }
        DisplayEndingMessage();
    }
}