using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    protected string _date;
    protected int _lenght;

    public Activity(string date, int lenght)
    {
        _date = date;
        _lenght = lenght;    
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetName();
   

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetName()} ({_lenght} minutes): Distance: {GetDistance()} km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km");
    }
}