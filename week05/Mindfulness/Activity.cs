using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    protected DateTime _startTime;

    public void DisplayStartingMessage()
    {
        bool isNotValid = false;

        Console.Clear();
        // Start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds.
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");

        do {
            Console.Write("How much time, in seconds, would you like for your session?  ");
            try
            {
                _duration = int.Parse(Console.ReadLine());
                isNotValid = false;
            }
            
            catch(FormatException)
            {
                isNotValid = true;
                Console.WriteLine("");
                Console.WriteLine("Sorry, your session time needs to be a whole number. Please try again.");
                Console.WriteLine("");    
            }

        } while(isNotValid == true);   
            
        
        Console.Clear();
        //  Tell the user to prepare to begin and pause for several seconds.
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        // End with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
        Console.WriteLine("Well done!!");
        ShowSpinner(6);
        
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(6);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(seconds);

        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        Thread.Sleep(1000);
        if(seconds < 10)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        else
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b");
            }
        }
    }
}