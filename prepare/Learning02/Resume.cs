using System;
using System.Collections.Generic; //requried when we use a list
public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.Write("Jobs: ");
        //now we need to enter a list we can use the foreach loop
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}