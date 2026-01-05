using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percentage: ");
        string userGrade = Console.ReadLine();
        
        int gradePercent = int.Parse(userGrade);
        string letter = "";

        if(gradePercent >= 90)
        {
            letter = "A";
        }

        else if(gradePercent >= 80)
        {
            letter = "B";
        }

        else if(gradePercent >= 70)
        {
            letter = "C";
        }

        else if(gradePercent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        string sign = "";
        int onesDigit = gradePercent % 10;

        if(onesDigit >= 7)
        {
            sign = "+";
        }

        else if(onesDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Erasing the "+" for the A grade
        if(gradePercent >= 93)
        {
            sign = "";
        }
        
        // Erasing the "+" and "-" for the F grade
        if(letter == "F")
        {
            sign = "";
        }
        
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if(gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("Stay focused and you'll get a better grade next time.");
        }
    }
}