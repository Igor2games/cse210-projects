using System;
// Made it so its not possible to record an already completed Goal.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}