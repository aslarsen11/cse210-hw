using System;

public class SimpleGoal : Goal
{ 
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Marks the SimpleGoal is complete. Returns the point value associated with recording the event.
    public override int RecordEvent()
    {
        _isComplete = true;

        Console.WriteLine($"Good job! You have earned {_points} points!");
        return int.Parse(_points);
    }

    // Returns true if the goal is completed.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // GetDetailsString will return the details of a goal that could be shown in a list. Includes the "X" for the checkbox, the name, and the description.
    public override string GetDetailsString()
    {
        string temp = "[";
        
        if (_isComplete)
            temp += "X] ";
        else
            temp += " ] ";
        temp = temp + _shortName + " (" + _description + ")";

        return temp;
    }

    // Provides all the details of the SimpleGoal in the format needed to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        string goalIsComplete;

        if(_isComplete)
        {
            goalIsComplete = "True";
        }

        else
        {
            goalIsComplete = "False";
        }

        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{goalIsComplete}";
    }
}