using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}