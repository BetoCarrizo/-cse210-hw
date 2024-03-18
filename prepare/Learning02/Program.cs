using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1.jobTitle = "Software Engineer";
        job1.company= "Microsoft";
        job1.statYear = 2019;
        job1.endYear =2022;

        Job job2 = new Job();

        job2.jobTitle = "Manager";
        job2.company= "Apple";
        job2.statYear = 2022;
        job2.endYear =2023;


        Resume resume = new Resume();
        resume.name= "Allison Rose";


        resume.jobs.Add(job1);
        resume.jobs.Add(job2);

        resume.Display();

    }
}







