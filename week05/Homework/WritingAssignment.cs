using System;

public class WritingAssignment : Assignment
{
    private string _title = "";

    // Constructor, calls the base contructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        // Returns the inherited variables that have been set in the WritingAssignment constructor
        return $"{_title} by {_studentName}";
    }
}