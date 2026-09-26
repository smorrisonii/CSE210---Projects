using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new empty list.
        List<int> numberList = new List<int>();

        // Set a variable for the user's input.
        int userInput = -1;

        // Create a variable for the sum.
        float sum = 0;

        // Create a variable for the average.
        float average;

        // Create a variable for the highest number.
        int largestNumber = 0;

        // Instruct the user how to use the program.
        Console.WriteLine("Enter a list of positive integers.");
        Console.WriteLine("Enter zero when you are finished.");

        // Get the user's input and keep looping until zero is inputted.
        while (userInput != 0)
        {
            // Get a number from the user and store it in an integer.
            Console.WriteLine("Enter a number:");
            string currentInput = Console.ReadLine();
            userInput = int.Parse(currentInput);

            // Add the user's number to the list unless it is zero.
            if (userInput != 0)
            {
                numberList.Add(userInput);
            }
        }
        
        // Go through the list and find the sum and the largest number.
        for (int i = 0; i < numberList.Count; i++)
        {
            sum = sum + numberList[i];

            if (numberList[i] > largestNumber)
            {
                largestNumber = numberList[i];
            }
        }

        // Find the average of the list.
        average = sum / numberList.Count;

        // Display the results.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}