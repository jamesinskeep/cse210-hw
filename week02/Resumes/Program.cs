using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Internet Director";
        job1._company = "Toyota Santa Monica";
        job1._startYear = "2004";
        job1._endYear = "2013";

        Job job2 = new Job();
        job2._jobTitle = "Finance Director";
        job2._company = "AutoNation Toyota Cerritos";
        job2._startYear = "2013";
        job2._endYear = "2021";

        Job job3 = new Job();
        job3._jobTitle = "Finance Director";
        job3._company = "Moss Bros. Auto Group";
        job3._startYear = "2021";
        job3._endYear = "Present";


        Resume myResume = new Resume();
        myResume._name = "James Inskeep";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        
        myResume.Display();
    }
}