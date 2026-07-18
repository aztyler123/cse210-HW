using System;
using System.Collections.Generic;

namespace YoutubeMonitor
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }

        public List<Comment> Comments { get; set; }


        public Video(string title, string author, int lengthinseconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthinseconds;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public int GetCommentCount()
        {
            return Comments.Count;
        }
    }
}