using System;


//Entry
//_date:string (this is due to how dates are written its a string). _userResponse:string. _prompt:string.
//Display void

//Save to a File or Journal
//_jornal:List<entry>. (gets another entry every time the user puts stuff in. )
//DisplayAll() void., SaveToFile(file)., LoadFromFile(file)

//Prompts
//_prompts:List<Prompt>.(Its the 5 different provided questions.) (use GetRandomPrompt())
//Display void
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        promptGenerator generator = new promptGenerator(); //make sure the second one the same as the first
        string userInput = "";

        while (userInput != "5") //5 quits the program
        {
            Console.WriteLine("Please enter the digit corresponding your choice: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n"); //When I debug I want to see of \n works for a new line entry.
            Console.WriteLine("Please provide your choosen action: ");
            userInput = Console.ReadLine();

            //begin if else loops for specification
            if (userInput == "1") //Write clarifciation for the journal
            {
                string randomPrompt = generator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("-- ");
                string response = Console.ReadLine();

                //We need to attach the current date and time with each journal entry Date.Time
                string date = DateTime.Now.ToShortDateString();

                //Create a new entry
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = response;

                //add it the jounral
                myJournal.AddEntry(newEntry);
            }
            else if (userInput == "2") //Display entries
            {
                myJournal.DisplayAll();
            }
            else if (userInput == "3") //Load entries
            {
                Console.Write("What is the Filename: ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }
            else if (userInput == "4") //Save Entries
            {
                Console.Write("What is the Filename: ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }
        }

        Console.WriteLine("Have a nice day");
    }
}