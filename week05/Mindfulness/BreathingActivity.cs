using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by pacing your breathing. Breathe in and out slowly. Clear your mind and focus on the air going in, and going out.";
    }

    public void Run()
    {
        int countDown = 0;
        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(_duration);

        // Loops for the number of seconds the user specified for the duration
        while (DateTime.Now <= endTime)
        {
            if(countDown < 6)
            {
                countDown = countDown + 2;
            }

            Console.WriteLine("");
            Console.Write("Breathe in... ");
            ShowCountDown(countDown);
            Console.Write("\n");

            Console.Write("Now breathe out... ");
            ShowCountDown(countDown);
            Console.WriteLine("");
        }        
    }
}