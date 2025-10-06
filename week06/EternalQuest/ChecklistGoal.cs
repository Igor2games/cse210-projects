public class ChecklisteGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklisteGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
       return true;
    }
}
