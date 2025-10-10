public class SwimmingActivity : Activity
{
    private int _laps;
    private string _name = "Swimming";

    public SwimmingActivity(string date, int lenght, int laps) : base(date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _laps = laps;
    }

    public override string GetName()
    {
        return _name;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _lenght * 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}