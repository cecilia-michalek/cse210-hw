using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        /*Job job1 = new Job();
        job1._company = "Intel";
        Job job2 = new Job();
        job2._company = "Apple";

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);*/

        
            Job job1 = new Job();
            job1._company = "Intel";
            job1._jobTitle = "Developer";
            job1._startYear = 2000;
            job1. _endYear = 2021; 

            Job job2 = new Job();
            job2._company = "Apple";
            job2._jobTitle = "Administrator";
            job2._startYear = 2021;
            job2. _endYear = 2023; 


            //job1.DisplayJobDetails();

            Resume myResume = new Resume();
            myResume._name = "Cecilia Borba";

            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.DisplayJobDetails();
            
        }

    }