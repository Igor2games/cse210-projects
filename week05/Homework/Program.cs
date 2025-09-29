using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine($"{assignment1.GetSummary()}");
        Console.WriteLine("");

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment wassigment1 = new WritingAssignment("Mary Waters", "Europen History", "The Causes of World War II");
        Console.WriteLine(wassigment1.GetSummary());
        Console.WriteLine(wassigment1.GetWritingInformation());
    }
}