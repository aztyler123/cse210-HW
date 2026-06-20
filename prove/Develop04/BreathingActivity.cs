using System;

namespace MindfulnessApp
{
    //our two  public calls
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {}
        public override void RunActivity()
        {
            DisplayStartingMessage();

            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountdown(5);
                elapsed += 5;

                if (elapsed >= _duration) break;

                Console.WriteLine("Breathe out...");
                ShowCountdown(5);
                elapsed += 5;
            }

            DisplayEndingMessage();
            //I think I got off deleting some notes and my tabs are off
        }
    }
}