using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text) // Constructor
    {
        _text = text;
        _isHidden = false;
    }

    // The word to be replaced with "_" to hide it.
    public void Hide()
    {
        _isHidden = true;
    }

    // The word as originally stored in the scriptures list to be printed out.
    public void Show()
    {
        _isHidden = false;
    }

    // Used in a loop in Scripture.cs file, to show what each word's Boolean value is.
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //Displays either the word (_isHidden is false) or underscores (_isHidden is true). Uses the length of _text to determine the number of underscores to be used.
        if(_isHidden)
        {
            string tempDisplay = "";

            foreach(char i in _text)
                tempDisplay += "_";

            return tempDisplay;
        }

        else
        {
            return _text;
        }
    }
}