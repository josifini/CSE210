using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your name? ");
    
       
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobcompany = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Developer";
        job2._jobcompany = "Microsoft";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = Console.ReadLine();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

    
        myResume.Display();
    }
}