using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List of entries of user's input
    public List<Entry> _entries = new List<Entry>();
    public Entry reorderEntry = new Entry();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            // Calls the Display method in the Entry.cs file 
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // The false parameter is to tell StreamWriter function to overwrite the existing file.
        using (StreamWriter outputFile = new StreamWriter(file, false))
        {    
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader readFile = File.OpenText(file))
        {
            string line;
            while ((line = readFile.ReadLine()) != null)
            {
                if(_entries.Count > 0)
                {
                    _entries.Clear();
                }
                    string[] parts = line.Split("|");

                    // Place values into a new Entry
                    Entry tempEntry = new Entry();
                    tempEntry._date = parts[0];
                    tempEntry._prompt = parts[1];
                    tempEntry._entry = parts[2];

                    // Adding the three parts of the temporary entry to the Journal Entry List.
                    _entries.Add(tempEntry);
            }
        }
    }    
}