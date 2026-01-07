using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Mountain America Credit Union";
        job1._jobTitle = "Branch Teller";
        job1._startYear = 2015;
        job1._endYear = 2023;

        Job job2 = new Job();

        job2._company = "JB Accounting & Tax";
        job2._jobTitle = "Accounting Assistant";
        job2._startYear = 2023;
        job2._endYear = 2026;

        Resume userResume = new Resume();

        userResume._name = "Christian Wolff";
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        Console.WriteLine("");
        Console.WriteLine("       View Resume");
        Console.WriteLine("");

        // Calls the Display method in the Resume.cs file
        userResume.Display();

        Console.WriteLine("");
    }
}