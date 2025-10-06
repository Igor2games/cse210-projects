using System;
// Made it so its not possible to record an already completed Goal.
// Eternal Goals display the amount of times they have been completed on their Checkamark.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}