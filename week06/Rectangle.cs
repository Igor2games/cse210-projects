using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{
    private double _lenght;
    private double _

    public Square(double side, string color) : base(color)
    {
        _color = color;
        _side = side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}