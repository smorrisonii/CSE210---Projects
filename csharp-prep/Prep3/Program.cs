using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueGame = true;

        string response = "y";

        while (continueGame == true)
        {
            // Generate a random "magic number."
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Set the user's response to zero.
            int userNumber = 0;
            
            // Create a variable for the number of guesses.
            int numberOfGuesses = 0;

            string plurality = "";

            bool validResponse = false;

            bool inputError = false;

            // Play the game.
            while (userNumber != magicNumber)
            {
                while (!validResponse)
                {
                    validResponse = false;
                    inputError = false;

                    try
                    {
                        Console.WriteLine("What is your guess?");
                        string userResponse = Console.ReadLine();
                        userNumber = int.Parse(userResponse);
                    }
                    catch (FormatException)
                    {
                        inputError = true;
                    }

                    if (userNumber <= 0 || userNumber > 100)
                    {
                        Console.WriteLine("The response must be an integer between 1 and 100.");
                        Console.WriteLine("Please try again.");
                        inputError = true;
                    }
                    
                    if (!inputError)
                    {
                        validResponse = true;
                    }
                }
                // Get the user's response.

                // Increase the number of guesses by one.
                numberOfGuesses ++;

                // Tell the user higher or lower.
                if (userNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                validResponse = false;
            }

            // Tell the user they got the number right.
            Console.WriteLine($"Congratulations! The magic number was {magicNumber}.");

            // Determine the plurality of guesses.
            if (numberOfGuesses != 1)
            {
                plurality = "es";
            }

            // Tell the user how many guesses it took to get right.
            Console.WriteLine($"It took you {numberOfGuesses} guess{plurality} to get it right.");

            while (validResponse == false)
            {
                validResponse = false;
                inputError = false;

                // Ask the user if they want to play again.
                Console.WriteLine("Do you want to play again? (y/n)");
                response = Console.ReadLine();

                if (response != "y" && response != "n")
                {
                    inputError = true;
                }

                if (inputError)
                {
                    Console.WriteLine("Please input 'y' or 'n'");
                }
                else
                {
                    validResponse = true;
                }
            }

            if (response != "y")
            {
                continueGame = false;
            } 
        }
    }
}
