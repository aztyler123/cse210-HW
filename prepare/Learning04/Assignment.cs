using System;

namespace HomeworkAssignmentApp
{
    public class Assignment
    {
        //The private field or variables that can't be messed wwith
        private string _studentName;
        private string _topic;

        //Constructor add here to limit
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }

        //make sure to put this helper property or you will have 7 errors.
        public string GetStudentName()
        {
            return _studentName;
        }

    }
}