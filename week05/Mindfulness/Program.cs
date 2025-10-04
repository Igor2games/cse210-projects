using System;
//The Reflecting activity doesnt repeat questions and resets if it goes trough all questions.
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        string option = "5";
        Console.Clear();

        while (option != "4")
        {
            Console.WriteLine($"Menu options:");
            Console.WriteLine($"   1. Start {breathingActivity.GetName()}");
            Console.WriteLine($"   2. Start {reflectingActivity.GetName()}");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine("");

            if (option == "1")
            {
                breathingActivity.Run();
            }
            else if (option == "2")
            {
                reflectingActivity.Run();
            }
        }
        
    }
}