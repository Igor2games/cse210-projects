public abstract class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}