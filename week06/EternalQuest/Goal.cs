public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDeatiledString()
    {
        if (IsComplete())
        {
            string text = $"[X] {_shortName} ({_description})";
            return text;
        }
        else
        {
            string text = $"[ ] {_shortName} ({_description})";
            return text;
        }
    }
}