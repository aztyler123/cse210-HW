using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptureList = new List<Scripture>();
        //we need to call our reference class
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        //we need the actual scripture
        string text1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        scriptureList.Add(new Scripture(ref1, text1));

        Reference ref2 = new Reference("John", 3, 16);
        string text2 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
        scriptureList.Add(new Scripture(ref2, text2));

        Reference ref3 = new Reference("1 Nephi", 10, 19);
        string text3 = "For he that diligently seeketh shall find; and the mysteries of God shall be unfolded unto them, by the power of the Holy Ghost as well in these times as in times of old, and as well in times of old as in times to come; wherefore, the course of the Lord is one eternal round.";
        scriptureList.Add(new Scripture(ref3, text3));

        Reference ref4 = new Reference("1 Nephi", 2, 15);
        string text4 = "And my Father dwelt in a tent";
        scriptureList.Add(new Scripture(ref4, text4));

        Reference ref5 = new Reference("3 Nephi", 11, 14);
        string text5 = "Arise and come forth unto me, that ye may thrust your hands into my side, and also that ye may feel the prints of the nails in my hands and in my feet, that ye may know that I am the God of Israel, and the God of the whole earth, and have been slain for the sins of the world.";
        scriptureList.Add(new Scripture(ref5, text5));

        //use a foreach loop to make it more of a game with more opportunities to practice.
        foreach (Scripture scripture in scriptureList)
        //Now loop it to make it work until user quits
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("The words are all hidden. Goodluck! ");
                    Console.WriteLine("Press Enter to move onto the next Scripture. ");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Press Return/Enter to hide words, or type 'quit' to end: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3); //we need to hide a few words each time.
            }
        }
        Console.Clear();
        Console.WriteLine("You have made it through all the scriptures. Fantastic Job!!");
    }
}