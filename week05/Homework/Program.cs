using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine($"{assignment1.GetSummary()}");
    }
}