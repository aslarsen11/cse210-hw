using System;
using System.Collections.Generic;

public class PromptGenerator
{   
    // A list of indexes of what has already been prompted to the user.
    public List<int> indexes = new List<int>();
    Random randomGenerator = new Random();
    public int endOfList = 0;

    // A list for the question prompts
    public List<string> _prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

    public string GetRandomPrompt()
    {
        int length = _prompts.Count;
        bool isDuplicatePrompt = false;
        int promptIndex = randomGenerator.Next(0, length);
        
        if(endOfList == length)
        {
            indexes.Clear();
            endOfList = 0;
        }

        // Keep looping until the random index isn't one that's already been used.
        do{
            // Check if the index for the prompt list has already been used.
            if(indexes.Contains(promptIndex))
            {
                isDuplicatePrompt = true;
                promptIndex = randomGenerator.Next(0, length);
            }
            
            else
            {
                indexes.Add(promptIndex);
                isDuplicatePrompt = false;
            }

        }while (isDuplicatePrompt == true);

        string promptText = _prompts[promptIndex];
        endOfList++;
        return promptText;
    }
}
