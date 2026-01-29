// Added to the program, in the GoalManager.cs file, is the _inspirations list and the _levels list. When the user's score reaches a certain range they level up, and they get an inspiration to cheer them on in reaching their goals.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalM = new GoalManager();

        Console.WriteLine("");
        Console.WriteLine("          Welcome to Your Eternal Quest Program");

        goalM.Start();
        Console.WriteLine("Program Closing...");
        Console.WriteLine("");
    }
}