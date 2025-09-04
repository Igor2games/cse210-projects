using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade <= 89)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade <= 79)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}!");

        if (grade >= 70)
        {
            Console.Write("Congratulations, you passed!");
        }
        else
        {
            Console.Write("You did not pass, better luck next time!");
        }

    }
}