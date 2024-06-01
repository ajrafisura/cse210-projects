using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("June 1 2024", 45, 5.2);
        Biking biking = new Biking("June 6 2024", 120, 30);
        Swimming swimming = new Swimming("June 12 2024", 30, 10);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }
}