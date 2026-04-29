using System;

class Program
{
    static void Main(string[] args)
    {
        Displaywelcome();
        string name = promptUserName();
        int favoriteNumber = promptUserNumber();
        float year;
        promptBirthYear(out year);
        //int favoriteNumber = promptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);//I just decided to use the number they already gave me makes things easier.
        DisplayResult(name, squareNumber, year);

    }

    static void  Displaywelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string promptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name; //returns the name

    }

    static int promptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine()); //must use parse becasue it is an interger.
        return number; //make sure to return the number thats what we want.
    }

    static void promptBirthYear(out float year)
    {
        Console.Write("What year were you born? ");
        year = float.Parse(Console.ReadLine());
    }
    
    static int SquareNumber(int favoriteNumber)
    {
        int squared = favoriteNumber * favoriteNumber;
        return squared;
    }

    static void DisplayResult(string name, int square, float birthYear)
    {
        int currentYear = 2026;
        int age = currentYear - (int)birthYear;

        Console.WriteLine($"{name}, the square of your favorite number {square}. ");
        Console.WriteLine($"{name}, and your will turn {age} this year. ");
    }
}