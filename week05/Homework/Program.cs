using System;

class Program
{
    static void Main(string[] args)
    {
        // The base class object
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        // variable gets overwritten every time GetSummary method is called. 
        string studentAndTopic = assignment.GetSummary();

        Console.WriteLine("");
        Console.WriteLine("       View Student");
        Console.WriteLine("");
        Console.WriteLine(studentAndTopic);

        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");

        // The derived class object for MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        // The derived class object for WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        studentAndTopic = mathAssignment.GetSummary();
        string mthAssgnmnt = mathAssignment.GetHomeworkList();

        Console.WriteLine("");
        Console.WriteLine("       View Student");
        Console.WriteLine("");
        Console.WriteLine(studentAndTopic);
        Console.WriteLine(mthAssgnmnt);

        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");

        studentAndTopic = writingAssignment.GetSummary();
        string wrtngAssgnmnt = writingAssignment.GetWritingInformation();

        Console.WriteLine("");
        Console.WriteLine("       View Student");
        Console.WriteLine("");
        Console.WriteLine(studentAndTopic);
        Console.WriteLine(wrtngAssgnmnt);
        Console.WriteLine("");
    }
}