// Added to the program is loading the scriptures from the file, "myScriptures.txt", and putting the scriptures into a list. Then a foreach loop to send the separate parts of the reference and the scripture to the correct constructors. In a while loop is the prompt for the user to start memorizing all the scriptures in the file, until the user doesn't type in "yes", or until the loop reaches the end of the scripture list.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        string continueMemorizing = "yes";
        int wordsToHide = 3;
        int scriptureIndex = 0;
        string file = "myScriptures.txt";
        // Getting all the data from the text file.
        string[] lines = System.IO.File.ReadAllLines(file);
        
        // List of the scriptures in the myScriptures file.
        List<Scripture> s = new List<Scripture>();

        // splits up each line in file and calls the correct constructor - either a single verse or a range of verses
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");

            Reference tempEntry;
            // Place values into a new Reference
            if (parts[3] == "")
                // Uses References first overloaded constructor
                tempEntry = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            else
                // Uses References second overloaded constructor
                tempEntry = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            
            // Uses the Scripture constructor, using the reference object (tempEntry) and the scripture text 
            s.Add(new Scripture(tempEntry, parts[4]));
        }
        
        Console.WriteLine("");
        Console.WriteLine("     Scripture Memorizer Program");
        Console.WriteLine("");

        // Loops until user doesn't enter "yes" and the Scripture object hasn't gotten to the end of the list of scriptures.
       while(continueMemorizing == "yes" && scriptureIndex < s.Count)
       {
            do
            { 
                Console.WriteLine("Scriptures in the file: ");

                Console.WriteLine(s[scriptureIndex].GetDisplayText());
                Console.WriteLine(" ");

                Console.WriteLine("");
                Console.Write("Press any key to continue or type 'done' to start memorizing the next scripture: ");
                userChoice = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                
                if(userChoice != "done" && !s[scriptureIndex].IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("     Scripture Memorizer Program");
                    Console.WriteLine("");
                    s[scriptureIndex].HideRandomWords(wordsToHide);
                }

            } while (userChoice != "done" && !s[scriptureIndex].IsCompletelyHidden());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     Scripture Memorizer Program");
            Console.WriteLine("");
            Console.WriteLine(s[scriptureIndex].GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("How did you do? Press enter to reveal the scripture.");
            Console.ReadLine();
            s[scriptureIndex].ShowAllWords();
            Console.WriteLine(s[scriptureIndex].GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Enter 'yes' to start memorizing the next scripture. Enter 'quit' to exit the program.");
            continueMemorizing = Console.ReadLine();
            Console.WriteLine("");

            if(continueMemorizing == "yes")
                scriptureIndex++;

        }

        Console.WriteLine("");
        Console.WriteLine("Ending program...");
        Console.WriteLine("");
    }
}