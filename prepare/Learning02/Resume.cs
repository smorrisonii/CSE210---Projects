// Imports
using System;
using System.Security.Cryptography.X509Certificates;

// Define the resume class.
public class Resume
{
    // Define the member variables.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Define a method to display the information.
    public void Display()
    {
        // Display the name.
        Console.WriteLine($"Name: {_name}");

        // Display the list of jobs.
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}