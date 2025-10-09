using System.ComponentModel;

public class EternalGoal : Goal
{
    private int _timesCompleted = 0;

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public EternalGoal(string name, string description, string points, int timeCompleted) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _timesCompleted = timeCompleted;
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDeatiledString()
    {
        string text = $"[{_timesCompleted}] {_shortName} ({_description})";
        return text;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},{_timesCompleted}";
    }
}
