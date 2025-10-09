using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.IO;

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

            if (menu == "3")
            {
                SaveGoals();
            }

            if (menu == "4")
            {
                LoadGoals();
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

        if (newMenu == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            Console.Clear();
        }

        if (newMenu == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();

            ChecklisteGoal checklisteGoal = new ChecklisteGoal(name, description, points, int.Parse(target), int.Parse(bonus));
            _goals.Add(checklisteGoal);
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

    public void SaveGoals()
    {
        Console.Write("What is the filename for the Goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the Goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line.Contains(":"))
            {
                string[] parts = line.Split(":");

                string goalType = parts[0];
                string goalData = parts[1];

                if (goalType == "SimpleGoal")
                {

                    string[] dataStrip = goalData.Split(",");

                    string name = dataStrip[0];
                    string description = dataStrip[1];
                    string points = dataStrip[2];
                    bool complete = bool.Parse(dataStrip[3]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, complete);
                    _goals.Add(simpleGoal);
                }

                if (goalType == "EternalGoal")
                {

                    string[] dataStrip = goalData.Split(",");

                    string name = dataStrip[0];
                    string description = dataStrip[1];
                    string points = dataStrip[2];
                    int timeCompleted = int.Parse(dataStrip[3]);

                    EternalGoal eternalGoal = new EternalGoal(name, description, points, timeCompleted);
                    _goals.Add(eternalGoal);
                }

                if (goalType == "ChecklistGoal")
                {

                    string[] dataStrip = goalData.Split(",");

                    string name = dataStrip[0];
                    string description = dataStrip[1];
                    string points = dataStrip[2];
                    int target = int.Parse(dataStrip[3]);
                    int bonus = int.Parse(dataStrip[4]);
                    int timeCompleted = int.Parse(dataStrip[5]);

                    ChecklisteGoal checklisteGoal = new ChecklisteGoal(name, description, points, target, bonus, timeCompleted);
                    _goals.Add(checklisteGoal);
                }
            }
            else
            {
                _score = int.Parse(line);
            }
        }
    }
}