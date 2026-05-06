using System;

public class Job
{
    //here is our variables for the class job
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display() //make sure to have parentheses here or it won't work
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}