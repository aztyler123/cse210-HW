using System;

namespace HomeworkAssignmentApp
{
    public class MathAssignment : Assignment
    {
        //private field for the specific things in our starting diagram.
        private string _textbookSection;
        private string _problems;

        //Constructor calling to the base
        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }

    }
}