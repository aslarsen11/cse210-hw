using System;

class Program
{
    static void Main(string[] args)
    {   
        // Getting the current date
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();

        List<Activity> activities = new List<Activity>();

        // One activity of each type
        Running run = new Running(date, 30, 3.0);
        Cycling cycle = new Cycling(date, 30, 12);
        Swimming swim = new Swimming(date, 30, 30);

        // Each activity put into the activities list
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        Console.WriteLine("");
        Console.WriteLine("          Exercise Tracking Program");

        // Iterate through the activities list and call the GetSummary method on each activity and display the results.
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

        Console.WriteLine("");
    }
}