public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        name = _name;
        description = _description;
    }

    public string GetName()
    {
        return _name;
    }
}