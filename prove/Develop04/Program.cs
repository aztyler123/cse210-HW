using System;
using System.Collections.Generic;
using System.Threading;

//be careful not to capitalize the menu because then it throws things out of wack.
namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //take the time and write each different step for the user to type.
            int choice = 0;

            //the loop continues until they quit
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine(" 1. Start breathing activity");
                Console.WriteLine(" 2. Start reflection activity");
                Console.WriteLine(" 3. Start listing activity");
                Console.WriteLine(" 4. Quit");
                Console.Write("Select a choice from the menu: ");

                //i need a way to sort and keep my user inside the bounds of an actual input

                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    ShowErrorMessage("Please put an input 1-3 for an action of 4 to quit.");
                    continue;
                }
                Activity activity = null;
                //changing between things
                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    case 2:
                        activity = new ReflectionActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("\nGoodbye ");
                        break;
                    case 5:
                        ShowErrorMessage("Please put an input 1-3 for an action of 4 to quit.");
                        //Console.WriteLine("This is an incorrect input. Please put in a number 1-3 or number 4 to quit. ");
                        //Thread.Sleep(1500);
                        break;

                }
                //i need something to nullify
                if (activity != null)
                {
                    activity.RunActivity();
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
            }
        }
        static void ShowErrorMessage(string message)
        {
            Console.WriteLine($"\n{message}");
            Thread.Sleep(2000);
        }

    }
}