using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine();

        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Apple";
        job1._startYear = 2014;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "System Analyst";
        job2._company = "Linux";
        job2._startYear = 2017;
        job2._endYear = 2025;

        Resume applicant = new Resume();
        applicant._name = "Napoleon Tumale";
        applicant.Jobs.Add(job1);
        applicant.Jobs.Add(job2);


        applicant.Display();

    }
}

