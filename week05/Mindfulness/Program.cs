// Added to the program in the ReflectingActivity.cs file, the program keeps track of the questions that have been displayed and loops to make sure none of the questions are duplicated and they've all been used only once in a session. Also in the Activity.cs file is a do while loop with try and catch blocks to ensure the user's input for the _duration variable is a whole number. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("          Welcome to the Mindfulness Program");

        string choice = "";
                
        do {
            Console.WriteLine("");
            Console.WriteLine("    Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.WriteLine("");
                BreathingActivity b1 = new BreathingActivity();
                b1.DisplayStartingMessage();
                b1.Run();
                b1.DisplayEndingMessage();
            }

            else if (choice == "2")
            {
                Console.WriteLine("");
                ReflectingActivity r1 = new ReflectingActivity();
                r1.DisplayStartingMessage();
                r1.Run();
                r1.DisplayEndingMessage();
            }

            else if (choice == "3")
            {
                Console.WriteLine("");
                ListingActivity l1 = new ListingActivity();
                l1.DisplayStartingMessage();
                l1.Run();
                l1.DisplayEndingMessage();
            }

            else if (choice == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Program Closing...");
                Console.WriteLine("");
            }

            else
            {
                // User input is invalid
                Console.WriteLine("");
                Console.WriteLine("Sorry, that is not one of the Menu options. Please select again.");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        } while (choice != "4");
    }
}