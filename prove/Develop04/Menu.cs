// Define the menu class.
class Menu
{
    // Set a list of options as a member variable.
    private List<string> _options = new List<string>()
    {
        "Breathe Activity",
        "Listen Activity", 
        "Reflect Activity",
        "Change Breathe Settings",
        "Change Reflect Settings",
        "Quit"
    };

    // Show all the options by a number.
    public void ShowMenu()
    {
        Console.WriteLine("Please choose an option to begin an activity: ");

        for (int index = 0; index < _options.Count(); index++)
        {
            Console.WriteLine($"{index + 1}: {_options[index]}");
        }
    }

    // Get the desired option from the user.
    public int GetResponse()
    {
        bool done = false;

        int finalResponse = 0;

        while (!done)
        {
            string response = Console.ReadLine();

            try
            {
                finalResponse = int.Parse(response);

                if (0 < finalResponse && finalResponse <= _options.Count())
                {
                    done = true;
                }
            }

            catch (FormatException)
            {
                done = false;
            }

            catch (OverflowException)
            {
                done = false;
            }

            if (!done)
            {
                Console.WriteLine($"Please input a whole number between 1 and {_options.Count()}");
            }
        }
        
        return finalResponse;
    }
}