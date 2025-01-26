using System;
using System.Security.Cryptography.X509Certificates;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
    }
}



// public class Resume
// {
//     public string _name;
//     public List<Job> _jobs;

//     public void Display()
//     {
//         Console.WriteLine($"Name: {_name}");
//         Console.WriteLine("Jobs:");
//         foreach (Job job in _jobs)
//         {
//             job.Display();
//         }
//     }
// }