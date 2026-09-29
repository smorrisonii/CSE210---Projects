// Imports.
using System;

// Define the program class.
public class Program
{
    // Set the main function.
    static void Main(string[] args)
    {
        // Create a new job and set its company name.
        Job job1 = new Job();
        job1._company = "Microsoft";

        // Create a second new job and set its company name.
        Job job2 = new Job();
        job2._company = "Apple";

        // Display both company names.
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);

        // Set the remainder of job1's instances.
        job1._jobTitle = "Software Developer";
        job1._startYear = 2019;
        job1._endYear = 2024;

        // Set the remainder of job2's instances.
        job2._jobTitle = "Software Designer";
        job2._startYear = 2024;
        job2._endYear = 2026;

        // Display the results using the Display function.
        job1.Display();
        job2.Display();

        // Create a new resume and set its job list.
        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Display the list in the resume.
        Console.WriteLine(resume1._jobs[0]._jobTitle);
        Console.WriteLine(resume1._jobs[1]._jobTitle);

        // Set the rest of resume1's instances.
        resume1._name = "Spencer Morrison";

        // Use the display method to display the information.
        resume1.Display();
    }
}