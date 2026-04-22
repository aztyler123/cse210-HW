using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        //Full separate variable walk through
        int x;
        x = 5;
        Console.WriteLine(x);
        // All in one go
        int y=5;
        Console.WriteLine(y);
        //How to ask for a user input in C# also assignment
        Console.Write("Enter your First Name: ");
        string firstname = Console.ReadLine();
        Console.Write("Enter your Last Name: ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"My name is {lastname}, {firstname} {lastname}");


    }

}