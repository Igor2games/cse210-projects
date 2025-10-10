using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 4.8);
        runningActivity.GetSummary();

        CyclingActivity cyclingActivity = new CyclingActivity("10 Mar 2023", 30, 9.6);
        cyclingActivity.GetSummary();
    }
}