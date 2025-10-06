using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "blue");
        Console.WriteLine($"The are of the square is: {square.GetArea()}");
    }
}