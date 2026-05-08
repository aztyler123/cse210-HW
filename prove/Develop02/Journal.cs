using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //helps allot and hold in memory our entries.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() //displaying all of what we put as an entry.
    {
        foreach (Entry entry in _entries)
        {
            entry.display(); //calls our entry class
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file)) //helps build the txt file.
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~{e._promptText}~{e._entryText}"); //e is used for syntax reasons and helps classify what we are using.
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); //we need to clear prior entries to make it easier to use.
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~"); //careful with commas for the split it can backfire in their journal entry changing to a Tilde
            
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}