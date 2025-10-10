public class CyclingActivity : Activity
{
    private double _speed;
    private string _name = "Cycling";

    public CyclingActivity(string date, int lenght, double Speed) : base(date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _speed = Speed;
    }

    public override string GetName()
    {
        return _name;
    }

    public override double GetDistance()
    {
        return _speed * _lenght/60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}