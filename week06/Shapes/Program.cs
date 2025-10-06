using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        Console.WriteLine($"The are of the square is: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("red", 7, 4);
        Console.WriteLine($"The are of the rectangle is: {rectangle.GetArea()}");

        Circle circle = new Circle("purple", 3);
        Console.WriteLine($"The are of the circle is: {circle.GetArea()}");
        Console.WriteLine("");

        List<Shape> shapes = [square, rectangle, circle];
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
            Console.WriteLine("");
        }
    }
}