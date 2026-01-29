using System;

public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    // Returns the point value associated with recording the event.
    public override int RecordEvent()
    {
        Console.WriteLine($"Good job! You have earned {_points} points!");
        
        return int.Parse(_points);
    }

    // Returns false since an Eternal Goal can never be completed.
    public override bool IsComplete()
    {
        return false;
    }

    // GetDetailsString will return the details of a goal that could be shown in a list. Includes the "X" for the checkbox, the name, and the description.
    public override string GetDetailsString()
    {
        string temp = "[ ] " + _shortName + " (" + _description + ")";

        return temp;
    }

    // Provides all the details of the EternalGoal in the format needed to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}|{_description}|{_points}";
    }
}