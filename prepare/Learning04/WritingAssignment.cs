using System;

namespace HomeworkAssignmentApp
{
    public class WritingAssignment : Assignment
    {
        //private variables
        private string _title;

        //Constructor to call to the base
        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            //pulling just the name out
            string studentName = GetSummary().Split(" - ")[0].Trim();
            return $"{_title} by {studentName}";
        }
    }
}