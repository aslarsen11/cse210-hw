using System;

public class ChecklistGoal : Goal
{
    // Track the number of times the goal has been completed
    private int _amountCompleted;

    // The end amount of times the goal should be completed
    private int _target;
    
    // The extra points once the _target value has been achieved
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, string points, int amountCompleted, string target, string bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
    }

    // Increments the number of times the Checklist Goal has been completed. Returns the point value associated with recording the event, including the bonus (when earned).
    public override int RecordEvent()
    {
        int userPoints = int.Parse(_points);
        
        _amountCompleted++;

        // The bonus has been earned
        if(_amountCompleted == _target)
        {
            Console.WriteLine($"Good job! You have earned {userPoints + _bonus} points!");
            return userPoints + _bonus;
        }

        else
        {
            Console.WriteLine($"Good job! You have earned {userPoints} points!");
            return userPoints;
        }
    }

    // Returns true if the goal is completed.
    public override bool IsComplete()
    {
        return false;
    }

    // Returns the details of the ChecklistGoal that could be shown in a list. If the target has been reached, includes the "X" for the checkbox. Also includes the goal name, and description. Shows the number of times the goal has been accomplished so far.
    public override string GetDetailsString()
    {
        string temp = "[";

        if (_amountCompleted == _target)
        {
            temp += "X] ";
        }

        else
        {
            temp += " ] ";
        }

        temp = temp + _shortName + " (" + _description + ") -- Currently completed: " + _amountCompleted + "/" + _target;

        return temp;
    }

    // Provides all the details of the ChecklistGoal in the format needed to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}