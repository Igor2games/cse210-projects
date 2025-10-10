public class RunningActivity : Activity
{
    private double _distance;
    private string _name = "Running";

    public RunningActivity(string date, int lenght, double distance) : base(date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _distance = distance;
    }

    public override string GetName()
    {
        return _name;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _lenght * 60;
    }

    public override double GetPace()
    {
        return _lenght / _distance;
    }
}