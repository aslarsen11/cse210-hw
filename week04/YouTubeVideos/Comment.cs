using System;

public class Comment
{
    public string _name;
    public string _commentText;

    // Displays the commenter's name & comment
    public void Display()
    {
        Console.Write("Name: ");
        Console.Write($"{_name}");
        Console.Write("    Comment: ");
        Console.WriteLine($"{_commentText}");
    }
}