using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each Job instance in the list of jobs and display them.
        foreach(Job j in _jobs)
        {
            // Calls the Display method in the Job.cs file 
            j.Display();
        }
    }
}