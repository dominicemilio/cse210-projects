// This is Resume.cs
using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables for the name and a job list
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Method to display resume information
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and display details
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}