using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    // Constructor, calls the base contructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        // Returns the inherited variables that have been set in the MathAssignment constructor
        return $"Section {_textbookSection} Problems {_problems}";
    }
}