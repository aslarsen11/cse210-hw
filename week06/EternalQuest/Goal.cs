using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    
    public Goal(string name, string description, string points) // Constructor
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // For each goal (as needed), marks if the goal is complete, or adds the number of times a goal has been completed. Returns the point value associated with recording the event, might contain a bonus
    public abstract int RecordEvent();

    // Returns true if the goal is completed.
    public abstract bool IsComplete();

    // Returns the details of a goal that could be shown in a list. Includes the "X" for the checkbox, the name, and the description. For checklist goals will be overridden to show the number of times the goal has been accomplished so far.
    public abstract string GetDetailsString();

    // Provides all the details of a goal in the format needed to save to a file, and then load later.
    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }
}