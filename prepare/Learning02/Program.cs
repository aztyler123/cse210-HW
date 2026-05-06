using System;
// Resume
// _name:string. _jobs:List<Job>
//Display(): Void

//Job
//_company:string.  _jobTitle:string. _startYear:int. _endYear:int.
//Display(): Void
class Program
{
    static void Main(string[] args)
    {
        // first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2022;
        job1._endYear = 2026;

        //second job instance
        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2024;

        //Resume first instance
        Resume resume1 = new Resume();
        resume1._personName = "Larry Fitzgerald";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Resume Second instance
        Resume resume2 = new Resume();
        resume2._personName = "Harry Potter";
        resume2._jobs.Add(job1);
        resume2._jobs.Add(job2);

        //Display what you have created above
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
        job1.Display();
        //Console.WriteLine(resume1._personName);
        //Console.WriteLine(resume2._jobs[0]._jobTitle);
        job2.Display();
        //Console.WriteLine(resume2._personName);
        //Console.WriteLine(resume2._jobs[1]._jobTitle);
        resume1.Display();
        resume2.Display();
    }
}