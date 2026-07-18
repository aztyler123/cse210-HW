using System;
using System.Collections.Generic;

namespace YoutubeMonitor
{
        class Program
    {
        static void Main(string[] args)
        {
            List<Video> videolist = new List<Video>();


            Video v1 = new Video ("C# Basics for a Beginner", "Kahn.netacademy", 1300);
            v1.AddComment(new Comment("Jessica", "The Class provided a rather nice background and understanding of applying code. "));
            v1.AddComment(new Comment("Bryson", "I absolutely hated it and there was no learning in the class. It was a reminder of why I don't like coding. "));
            v1.AddComment(new Comment("Justin", "The class was illuminating but awakened me to my weakness in coding. I hope to become better when I retake the class. "));
            videolist.Add(v1);

            Video v2 = new Video ("Fresh in Billions", "How to get rich", 2100);
            v2.AddComment(new Comment("Tyrone", "The guests gave great ideas for business opportunites and how to become rich."));
            v2.AddComment(new Comment("Hailey", "Terrible class I don't think I can listen to them about how to make money. They are liars. "));
            v2.AddComment(new Comment("Drake", "I really enjoyed this chat. It seemed like you really want us to achieve our dreams. "));
            videolist.Add(v2);

            Video v3 = new Video ("Broken Hearts", "Book of Mormon Helps in Healing", 715);
            v3.AddComment(new Comment("Joseph", "Alma 7:11- And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."));
            v3.AddComment(new Comment("Katelyn", "3 Nephi 17:7- Have ye any that are sick among you? Bring them hither. Have ye any that are lame, or blind, or halt, or maimed, or leprous, or that are withered, or that are deaf, or that are afflicted in any manner? Bring them hither and I will heal them, for I have compassion upon you; my bowels are filled with mercy."));
            v3.AddComment(new Comment("Brody", "You want me to send a verse nah bro just pray and be better. "));
            videolist.Add(v3);


            //write up our Display function
            Console.WriteLine("-----------Youtube Monitor-------");
            int videonumber = 1;
            foreach (Video video in videolist)
            {
                Console.WriteLine($"Video: {videonumber}: {video.Title}");
                Console.WriteLine($"Creator: {video.Author}");
                Console.WriteLine($"Duration: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
                Console.WriteLine($"Comments: ");

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"  --[{comment.CommenterName}]: {comment.CommentText}");
                }

                Console.WriteLine(new string('-', 50));
                videonumber++;
            }

            Console.WriteLine("Press any key to Exit the code");
            Console.ReadKey();

        }

            
    }
}
