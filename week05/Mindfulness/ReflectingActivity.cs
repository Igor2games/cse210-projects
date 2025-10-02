public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        name = _name;
        description = _description;
    }
}