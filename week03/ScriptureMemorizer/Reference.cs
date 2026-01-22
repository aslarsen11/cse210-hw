using System;

public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse) // First overloaded constructor
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) // Second overloaded constructor
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string referenceText;

        // First overloaded constructor gets used.
        if(_endVerse == 0)
        {
            referenceText = $"{_book} {_chapter}:{_verse}";
        }

        // Second overloaded constructor gets used.
        else
        {
            referenceText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return referenceText;
    }
}