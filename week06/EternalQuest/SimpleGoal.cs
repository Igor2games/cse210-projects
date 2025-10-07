public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{IsComplete()}";
    }
}