class Difficulty
{
    // Ask the user to select a difficulty.
    public int SetDifficulty()
    {
        bool done = false;
        int userNumber = 0;

        while (!done)
        {
            Console.WriteLine("Please set the difficulty from 1-10 (1 is easiest, 10 is the hardest)");

            string userInput = Console.ReadLine() ?? "";

            try
            {
                userNumber = int.Parse(userInput);

                if (userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("Please input a whole number 1-10.");
                }
                else
                {
                    done = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a whole number 1-10.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("That number is too large.");
            }
        }

        // Higher difficulty means smaller groups of words.
        int difficulty = 13 - userNumber;

        return difficulty;
    }

    // Ask the user what character should replace hidden letters.
    public string SetEmptySpace()
    {
        bool done = false;
        string userInput = "";

        while (!done)
        {
            Console.WriteLine("Please input the character that will replace hidden words.");

            userInput = Console.ReadLine() ?? "";

            int inputLength = userInput.Length;

            if (inputLength != 1)
            {
                Console.WriteLine("Please input only one character.");
            }
            else
            {
                done = true;
            }
        }

        return userInput;
    }
}