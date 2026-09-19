using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage did you get in class?");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string letterGrade;
        string sign;
        bool passedClass = true;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else
        {
            letterGrade = "F";
            passedClass = false;
        }

        if (grade < 70)
        {
            sign = "";
        }
        else if (grade > 93)
        {
            sign = "";
        }
        else if (grade % 10 <= 3)
        {
            sign = "-";
        }
        else if (grade % 10 >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your final grade is: {letterGrade}{sign}");

        if (!passedClass)
        {
            Console.WriteLine("Unfortunately, you did not pass the class.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
    }
}