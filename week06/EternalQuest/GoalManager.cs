using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public void Start()
    {
        Console.Clear();
        string menu = "0";
        _goals = new List<Goal>();

        while (menu != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Ceate New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                CreateGoal();
            }

            if (menu == "2")
            {
                ListGoalDetails();
            }

            if (menu == "5")
            {
                RecordEvent();
            }
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You Have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetName()}");
            number++;
        }
        Console.WriteLine("");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDeatiledString()}");
            number++;
        }
        Console.WriteLine("");
    }

    public void CreateGoal()
    {
        string newMenu = "0";

        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        newMenu = Console.ReadLine();

        if (newMenu == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            Console.Clear();
        }
    
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        string completedI = Console.ReadLine();

        int i = int.Parse(completedI);

        if (_goals[i - 1].IsComplete())
        {
            Console.WriteLine("Sorry, that Goal has already been completed.");
        }
        else
        {
            _goals[i - 1].RecordEvent();
            _score += _goals[i - 1].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[i - 1].GetPoints()} points!");
            Console.WriteLine($"You now have {_score} points");
            Console.WriteLine("");
        }
    }
}