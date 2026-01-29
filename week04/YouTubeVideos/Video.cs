using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    // a list of Comment objects
    public List<Comment> _comments = new List<Comment>();

    // Displays the title, author, length & number of comments
    public void Display()
    {
        Console.WriteLine("");
        Console.Write("Video Title: ");
        Console.WriteLine($"{_title}");
        Console.Write("Author: ");
        Console.WriteLine($"{_author}");
        Console.Write("Length: ");
        Console.WriteLine($"{_length} min.");
            
        Console.WriteLine("");
        Console.WriteLine($"    Number of Comments: {NumberOfComments()}"); 
        Console.WriteLine("     Comments - ");

        /// Iterates through the list of Comment objects
        foreach(Comment c in _comments)
        {
            // Calls the Display method in the Comments.cs file
            c.Display();
        }
    }

    // Returns the number of comments
    public int NumberOfComments()
    {   
        return _comments.Count();
    } 
}