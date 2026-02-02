using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private Random randomGenerator = new Random();

    // Constructor
    public ListingActivity() 
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        // a list of prompts
        _prompts.Add("Who is someone that you appreciate?");
        _prompts.Add("What are some of your personal strengths?");
        _prompts.Add("Who is someone that you have helped this week?");
        _prompts.Add("What are some of the times recently that you felt the Holy Ghost?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        string promptText = GetRandomPrompt();
        Console.WriteLine($"--- {promptText} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> userList = new List<string>(GetListFromUser());
        int entries = userList.Count;
        Console.WriteLine($"You listed {entries} items!");
    }

    public string GetRandomPrompt()
    {
        int length = 0;
        length = _prompts.Count;
        int promptIndex = randomGenerator.Next(0, length);

        string promptText = _prompts[promptIndex];
        return promptText;
    }

    public List<string> GetListFromUser()
    {
        string listEntry;
        List<string> userList = new List<string>();

        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(_duration);

        // Loops for the number of seconds the user specified for the duration
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            listEntry = Console.ReadLine();
            userList.Add(listEntry);
        }

        return userList;
    }
}