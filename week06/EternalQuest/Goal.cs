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


    public abstract void RecordEvent();

    public abstract bool _IsComplete();

    public string GetDeatiledString()
    {
        string text = $"[ ] {_shortName} ({_description})";
        return text;
    }
}