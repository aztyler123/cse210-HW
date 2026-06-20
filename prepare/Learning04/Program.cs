using System;

namespace HomeworkAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the mathassignment
            MathAssignment mathHW = new MathAssignment("Roberto", "Fractions", "7.3", "3-10, 20-21");
            Console.WriteLine(mathHW.GetSummary()); //grabs the list info
            Console.WriteLine(mathHW.GetHomeworkList());

            Console.WriteLine();


            //call the writingassignemnt
            WritingAssignment writingHW = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writingHW.GetSummary());
            Console.WriteLine(writingHW.GetWritingInformation());
        }
    }
}