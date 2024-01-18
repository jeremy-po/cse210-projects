using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Parts Advisor";
        job1._company = "JPOAuto";
        job1._startYear = 2017;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Sales";
        job2._company = "Motorist";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jeremy Oliver";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}