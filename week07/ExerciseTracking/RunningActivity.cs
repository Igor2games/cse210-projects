public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int lenght, double distance) : base(date, lenght)
    {
        _date = date;
        _lenght = lenght;
        _distance = distance;
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

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Running ({_lenght} minutes): Distance: {_distance} km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km");
    }
}