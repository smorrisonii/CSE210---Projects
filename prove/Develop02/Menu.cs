class Menu
{
    string _errorMessage = "Please input a whole number between 1 and 5.";

    public void DisplayOptions()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("    1: Write a new entry");
        Console.WriteLine("    2: Read your journal");
        Console.WriteLine("    3: Save Your journal");
        Console.WriteLine("    4: Load Your saved journal");
        Console.WriteLine("    5: View journal prompts");
        Console.WriteLine("    6: Quit");
    }

    public int GetInput()
    {
        bool done = false;
        int userInput = 0;

        while (!done)
        {
            bool error = false;

            string input = Console.ReadLine();
            try
            {
                userInput = int.Parse(input);
            }
            catch (FormatException)
            {
                error = true;
            }
            catch (OverflowException)
            {
                error = true;
            }

            if (error || userInput < 1 || userInput > 6)
            {
                Console.WriteLine(_errorMessage);
            }
            else
            {
                done = true;
            }
        }

        return userInput;
    }
}