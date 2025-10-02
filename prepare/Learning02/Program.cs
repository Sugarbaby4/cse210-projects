using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Electrical Engineer";
        job1._company = "Grand Collie Dam";
        job1._startYear = 2012;
        job1._endYear = 2016;


        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Baker Dam";
        job2._startYear = 2016;
        job2._endYear = 2021;


        Job job3 = new Job();

        job3._jobTitle = "Project Consultant";
        job3._company = "BPA";
        job3._startYear = 2021;
        job3._endYear = 2025;


        Resume myResume = new Resume();
        myResume._name = "Winter Lewis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}