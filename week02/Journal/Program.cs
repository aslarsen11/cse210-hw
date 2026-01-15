// Added to the program, in the PromptGenerator.cs file, the program ensures that the prompt questions don't repeat until all of them have been used once. 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        //Entry anEntry = new Entry();
        PromptGenerator prompt = new PromptGenerator();

        // Getting the current date
        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();

        Console.WriteLine("");
        Console.WriteLine("          Welcome to the Journal Program!");

        string choice = "";

        do {
            Console.WriteLine("");
            Console.WriteLine("    Menu");
            Console.WriteLine("1. Load your Journal");
            Console.WriteLine("2. Write an entry into your Journal");
            Console.WriteLine("3. Display your Journal");
            Console.WriteLine("4. Save your Journal to a file");
            Console.WriteLine("5. Quit Program");
            Console.WriteLine("");
            Console.Write("Enter the number for what would you like to do: ");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.WriteLine("");

                // prompts the user for a filename
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                // Check that file exists
                if(File.Exists(fileName))
                {
                    theJournal.LoadFromFile(fileName);
                }

                else
                {
                    Console.WriteLine("Sorry, that file can not be found. Please try again.");
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Question to help you write in your Journal:");
                string promptText = prompt.GetRandomPrompt();

                // Print out the random prompt
                Console.WriteLine(promptText);

                // Getting the user's journal entry
                Console.Write(">  ");
                string newEntry = Console.ReadLine();
                Entry anEntry = new Entry();

                // Putting the current date into the Entry object
                anEntry._date = dateText;

                // Putting the prompt into the Entry object
                anEntry._prompt = promptText;
                
                // Putting user's journal entry into the Entry object
                anEntry._entry = newEntry;
                
                // Putting the Entry object into the journal list
                theJournal.AddEntry(anEntry);
            }

            else if (choice == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("     My Journal");
                Console.WriteLine("");

                theJournal.DisplayAll();
            }

            else if (choice == "4")
            {
                Console.WriteLine("");

                // prompt the user for a filename
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                
                if(File.Exists(fileName))
                {
                    theJournal.SaveToFile(fileName);
                }

                else
                {
                    Console.WriteLine("Sorry, that file can not be found. Please try again.");
                }
            }

            else if (choice == "5")
            {
                Console.WriteLine("");
                Console.WriteLine("Program Closing...");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, that is not one of the Menu options. Please select again.");
                Console.WriteLine("");
                Console.WriteLine("");
            }

        } while(choice != "5");
    }
}