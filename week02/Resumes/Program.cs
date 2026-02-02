using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // Job is a class; job1 is an object; new is a keyword and works with Job() to be a constructor that makes an instance of that class 

        // for the object job1, are 4 variables with "_" in front, and the variables are given a value
        job1._company = "Mountain America Credit Union";
        job1._jobTitle = "Branch Teller";
        job1._startYear = 2015;
        job1._endYear = 2023;

        // Another instance of a class named job2
        Job job2 = new Job();
        // more variables for the job2 object
        job2._company = "JB Accounting & Tax";
        job2._jobTitle = "Accounting Assistant";
        job2._startYear = 2023;
        job2._endYear = 2026;

        // Resume is a class; userResume is an object; an instance of that class is being created
        Resume userResume = new Resume();

        // for the object userResume, is 1 variable, and _jobs is a List that is created in the Resume.cs file
        userResume._name = "Christian Wolff";
        
        // Add is a built-in method to add elements to the _jobs list
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