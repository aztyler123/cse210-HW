using System:
using System.Collections.Generic;

namespace MindfulnessApp
{
    //privates and other thinngs
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private Random _random;

        public ReflectionActivity() : base("Reflecion Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _random = new Random();
            _prompts = new List<string>
            {
                //put the provided prompts
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
            };

            _questions = new List<string>
            {
                //put the provided questions
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
            };
        }


        public override void RunActivity()
        {
            DisplayStartingMessage();

            int promptIndex = _random.Next(_prompts.Count);
            Console.WriteLine($"\n -> {_prompts[promptIndex]}");
            Console.WriteLine("\nwhen you have something in mind, press enter.");
            Console.ReadLine();

            int elapsed = 0;
            //make sure to set the starting point and then keep in mind the timing
            while (elapsed < _duration)
            {
                int questionIndex = _random.Next(_questions.Count);
                Console.WriteLine($"\n> {_questions[questionIndex]}");
                ShowSpinner(5);
                elapsed += 5;
            }

            DisplayEndingMessage();
        }
    }
}