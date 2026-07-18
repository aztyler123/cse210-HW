using System;
using System.Collections.Generic;

namespace YoutubeMonitor
{
    public class Comment
    {
        public string CommenterName{ get; set; } //we need to get from user and then help put the data in.
        public string CommentText{ get; set; } //record the notes and set them for data.

        public Comment(string commentname, string commenttext) //i put them as lowercase they threw up a ton of errors uppercased for second word.
        {
            //constructors which use lowercase first word.
            CommenterName = commentname;
            CommentText = commenttext;

        }
        
    }
}