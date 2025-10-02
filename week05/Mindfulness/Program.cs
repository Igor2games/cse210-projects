using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        string option = "5";
        Console.Clear();

        while (option != "4")
        {
            Console.Write($"Menu options:\n   1. Start {breathingActivity.GetName()}\n   4. Quit\nSelect a choice from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine("");

            if (option == "1")
            {
                breathingActivity.Run();
            }
        }
        
    }
}