using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // if statement example
        int x=5;
        int y=4;
        int z=3;
        if (x > y){
            Console.WriteLine("greater than");
        }
        //proper indentation for one in the other
        if (x > y)
        {
            if(x > z)
            {
                Console.WriteLine("greater than both");
            }
        }
        //It can support if else statements as well as if, else if, and else
        int u = 6;
        int v = 7;
        if (u > v)
        {
            Console.WriteLine("greater than");
        }
        else
        {
            Console.WriteLine("less than");
        }
        // use the == <=, >= just like in python
        // use camelcase for variable names lower case and then extra name parts uppercase

        //Assignemnt time
        Console.Write("What is the percentage for the student: ");
        int percentage = int.Parse(Console.ReadLine());
        string letter = "";
        //Console.Write($"{letter}");
        if (percentage >= 90)
        {
            //Console.Write("Grade:A ");
            letter = "Grade: A";
        }
        //else if (percentage <= 89 && percentage >= 80)
        else if (percentage >= 80)
        {
            //Console.Write("Grade:B ");
            letter = "Grade: B";
        }
        //else if (percentage <= 79 && percentage >= 70)
        else if (percentage >= 70)
        {
            //Console.Write("Grade:C ");
            letter = "Grade: C";
        }
        //else if (percentage <= 69 && percentage >= 60)
        else if (percentage >= 60)
        {
            //Console.Write("Grade:D ");
            letter = "Grade: D";
        }
        else
        {
            letter = "Grade: F";
        }
        if (percentage >= 70) //make sure after we changed letter to a string and percentage to the int we change all calls to the variable
        {
            Console.WriteLine($"You have Passed this class with a {letter}, {percentage}%. ");
            //Console.Write v Console.WriteLine
            //Console.WriteLine gets ride of the blacked out % sidn added due to Mac. 
        }
        else
        {
            Console.WriteLine($"You did not pass with {letter}, {percentage}% better luck next time. ");
        }
    }
}