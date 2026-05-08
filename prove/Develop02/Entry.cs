using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void display()
    {
        Console.WriteLine($"Date:{_date}, Prompt:{_promptText}, {_entryText}");
    }
}