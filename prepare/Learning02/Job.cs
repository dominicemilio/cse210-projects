// This is Job.cs
using System;

public class Job
{
    // Member variables to carry job info
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display the job info
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}