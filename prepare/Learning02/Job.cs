// Imports.
using System;

// Define the Job class.
public class Job
{
    // Define the member variables.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Define a method to display the job information
    public void Display()
    {
        // Display the information about the job.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}