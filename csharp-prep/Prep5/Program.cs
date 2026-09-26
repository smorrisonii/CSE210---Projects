using System;

class Program
{
    static void Main(string[] args)
    {
        int currentYear = 2026;

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string currentNumber = Console.ReadLine();
            int userNumber = int.Parse(currentNumber);

            return userNumber;
        }

        static int PromptUserBirthYear()
        {
            Console.WriteLine("Please enter the year you were born: ");
            string currentUserYear = Console.ReadLine();
            int userBirthYear = int.Parse(currentUserYear);

            return userBirthYear;
        }

        static int SquareNumber(ref int userNumber)
        {
            int squaredNumber = userNumber * userNumber;

            return squaredNumber;
        }

        static void DisplayResults(
            string userName, 
            int userBirthYear,
            int squaredNumber,
            int currentYear)
        {
            int returnedAge = currentYear - userBirthYear;
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
            Console.WriteLine($"{userName}, you will turn {returnedAge} this year.");
        }

        static void Main(int currentYear)
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int userBirthYear = PromptUserBirthYear();
            int squaredNumber = SquareNumber(ref userNumber);
            DisplayResults(userName, userBirthYear, squaredNumber, currentYear);
        }

        Main(currentYear);
    }
}