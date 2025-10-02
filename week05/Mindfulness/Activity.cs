using System.ComponentModel.DataAnnotations;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationstrings =["|","/","-","\\","|","/","-","\\"];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationstrings)
            {
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}