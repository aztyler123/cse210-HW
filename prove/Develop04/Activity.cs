using System;

namespace MindfulnessApp
{
    public class Activity
    {
        // Protected strings v the Private I have noticed that AI always suggests protected instead of private. I have found it seems easier to be seen but has a little less portection than if it was a private.
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void RunActivity()
        {
            //place holder remove later
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            
            // Basic validation for duration input
            if (!int.TryParse(Console.ReadLine(), out _duration))
            {
                _duration = 30; // handles if you just type strings or random numbers
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            // Basic spinner animation logic had to get help from AI to finish it.
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < seconds)
            {
                Console.Write("/"); Thread.Sleep(250); Console.Write("\b \b");
                Console.Write("-"); Thread.Sleep(250); Console.Write("\b \b");
                Console.Write("\\"); Thread.Sleep(250); Console.Write("\b \b");
                Console.Write("|"); Thread.Sleep(250); Console.Write("\b \b");
            }
        }

        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b"); // helps clear the line so it appears seamless. 
            }
        }
    }
}
