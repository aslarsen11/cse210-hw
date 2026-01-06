using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        
        int userNumber = PromptUserNumber();
        
        int numberSquared = SquareNumber(userNumber);
        
        DisplayResult(userName, numberSquared);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    // Function to prompt the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    // Function to get an integer and squares it
    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;

        return numberSquared;
    }

    // Function displays the user's name and the squared number
    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, your favorite number squared is {numberSquared}");
    }
}