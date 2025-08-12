using System;
using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity running = new RunningActivity(new DateTime(2025, 08, 1), 30, 3.1f);
        Activity cycling = new CyclingActivity(new DateTime(2025, 08, 2), 45, 15.0f);
        Activity swimming = new SwimmingActivity(new DateTime(2025, 08, 3), 60, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}