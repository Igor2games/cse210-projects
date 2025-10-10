using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 4.8);
        runningActivity.GetSummary();
    }
}