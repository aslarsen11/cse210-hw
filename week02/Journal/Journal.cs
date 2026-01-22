using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List of entries of user's input
    public List<Entry> _entries = new List<Entry>();
    bool isLoaded = false;
 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if(_entries.Count == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("The Journal is empty.\nSelect option #2 from the menu to write an entry into your journal.");
        }

        foreach(Entry entry in _entries)
        {
            // Calls the Display method in the Entry.cs file 
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    { 
        string[] lines;
        
        // Read in any lines that already exist in the journal.
        using (StreamReader readFile = File.OpenText(file))
        {
            lines = System.IO.File.ReadAllLines(file);
        }

        // The false parameter is to tell StreamWriter function to overwrite the existing file.
        using (StreamWriter outputFile = new StreamWriter(file, false))
        {
            if(!isLoaded)
            {
                foreach(string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

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
            // To make sure there won't be duplicate entries in the file.
            if(_entries.Count > 0)
            {
                _entries.Clear();
            }

            FileInfo fileInfo = new FileInfo(file);

            // Check that there is data in the file
            if (fileInfo.Exists && fileInfo.Length > 0)
            {
                while ((line = readFile.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");

                    // Place values into a new Entry
                    Entry tempEntry = new Entry();
                    tempEntry._date = parts[0];
                    tempEntry._prompt = parts[1];
                    tempEntry._entry = parts[2];

                    // Adding the three parts of the temporary entry to the Journal Entry List.
                    _entries.Add(tempEntry);
                }

                // To keep from having duplicate entries in the journal
                isLoaded = true;
            }

            // The journal file is empty
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("The Journal is empty.\nSelect option #2 from the menu to write an entry into your journal.");
            }
        }
    }    
}