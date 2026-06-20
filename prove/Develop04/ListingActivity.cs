using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    //make everything like the previous parts but this has a list as well
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private Random _random;

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _random = new Random();
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",
            };

        }
        public override void RunActivity()
        {
            DisplayStartingMessage();

            int promptIndex = _random.Next(_prompts.Count);
            Console.WriteLine($"\n -> {_prompts[promptIndex]}");
            ShowCountdown(5);

            //specify starting point
            int itemCount = 0;
            DateTime startTime = DateTime.Now;
            //makes sure to put .now for correct time today

            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemCount++;
                }
            }
            Console.WriteLine ($"\nYou listed {itemCount} items!");
            DisplayEndingMessage();
        }
    }
}