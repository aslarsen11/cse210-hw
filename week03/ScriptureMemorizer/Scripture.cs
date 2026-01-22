using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(); // a list of Word objects
    private int _wordCount;

    public Scripture(Reference reference, string text) // Constructor
    {
        string[] parts = text.Split(" ");
        _wordCount = parts.Length;

        // Looping through all the separate words in the scripture and creating a new object, and adding the words to the List of words
        foreach(string temp in parts)
        {
            Word w = new Word(temp);
            _words.Add(w);
        }

        // Give the temporary reference parameter that came from when the Scripture constructor was used, to the Reference object.
        _reference = reference;
    }   

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int wordIndex = 0;
        int count = 0;

        //Will loop the numberToHide times so long as IsCompletelyHidden returns false
        while (count < numberToHide && !IsCompletelyHidden())
        {
            wordIndex = randomGenerator.Next(0, _wordCount);
            if(!(_words[wordIndex].IsHidden()))
            {
                _words[wordIndex].Hide();
                count++;
            }  
        }
    }

    public string GetDisplayText()
    {
        // Calls the GetDisplayText method in the Reference.cs file, and concatenates the reference together
        string scriptureText = _reference.GetDisplayText() + " ";

        foreach(Word word in _words)
        {
            // Calls the GetDisplayText method in the Word.cs file, and concatenates the scripture together
            scriptureText = scriptureText + word.GetDisplayText() + " ";
        }

        return scriptureText;
    }

    // When returns true, program will move on to the next scripture.
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
                return false;
        }

        return true;
    }

    // Loops for every word in the scripture
    public void ShowAllWords()
    {
        foreach(Word word in _words)
        {
            word.Show();
        }
    }
}