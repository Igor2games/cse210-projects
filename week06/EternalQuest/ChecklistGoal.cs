public class ChecklisteGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklisteGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDeatiledString()
    {
        if (IsComplete())
        {
            string text = $"[X] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
            return text;
        }
        else
        {
            string text = $"[ ] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
            return text;
        }
    }
}
