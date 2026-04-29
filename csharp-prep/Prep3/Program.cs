using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int number = randomNumberGenerator.Next(1,101);
        //Console.Write("What is the magic number? ");
        //For earlier when we choose the number
        //int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());


        while(userGuess != number)
        {
            if (userGuess < number)
            {
                Console.WriteLine("Higher ");
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
            }
            else if (userGuess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("That is Correct! ");
    }
}

        //The normal while loop is below
        //string response = "yes";
        //while (response == "yes")
        //{
        //Console.Write("Do you want to continue? ");
        //response = Console.ReadLine();
        //}

        //the do-while loop that runs through it and then if you answer will run through the loop. 
        //string response;
        //do
        //{
            //Console.Write("Do you want to continue? ");
            //response = Console.ReadLine();
        //} while (response == "yes");
        
        //Basic for loop for the counting to 10.
        //for (int i = 0; i<10; i++) //++ increments our variable by 1.
        //{
            //Console.WriteLine(i);
        //}

        //foreach loops
        //foreach (string color in colors)
        //{
           // Console.WriteLine(color);
        //}