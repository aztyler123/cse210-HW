using System;

public class promptGenerator
{
    public List<string> _prompts = new List<string>
    {//commas will separate the different quesitons below. 
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, What would it be? ",
        "What about today would I have changed? Why?",
        "Who did I bump into unexpectedly today?"

    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        //when using a count in C# make sure it is a capital C.
        int index = random.Next(_prompts.Count); //generate a random index to help randomize the questions
        return _prompts[index];
    }
}