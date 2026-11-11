class Activity
{
    public string _name;
    public string _description;
    public int _pauseDuration = 5;
    public int _activityDuration = 30;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void ShowDescription()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public int GetPauseDuration()
    {
        bool done = false;
        int finalResponse = 0;

        Console.WriteLine("How long should the program pause for between activities?");

        while (!done)
        {
            string response = Console.ReadLine();
            try
            {
                finalResponse = int.Parse(response);
                done = true;
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
                Console.WriteLine($"Please input a whole number for how long the program should pause for.");
            }
        }
        
        return finalResponse; 
    }

    public void GetActivityDuration()
    {
        bool done = false;

        Console.WriteLine("How long would you like your session to be, in seconds?");

        while (!done)
        {
            string response = Console.ReadLine();
            try
            {
                _activityDuration = int.Parse(response);
                done = true;
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
                Console.WriteLine($"Please input a whole number for how long the session should last.");
            }
        }
    }

public void Pause(string pauseType, int pauseDuration)
{
    if (pauseDuration <= 0)
    {
        return;
    }

    bool isSymbol = pauseType == "symbol";

    string[] symbols = { "|", "/", "-", "\\" };

    int displayWidth = isSymbol ? 1 : pauseDuration.ToString().Length;
    int delay = isSymbol ? 500 : 1000;
    int iterations = isSymbol ? pauseDuration * 2 : pauseDuration;

    // Reserve space for the animation.
    Console.Write(new string(' ', displayWidth));

    for (int i = 0; i < iterations; i++)
    {
        // Move back to the beginning of the animation.
        Console.Write(new string('\b', displayWidth));

        // Choose what to display.
        if (isSymbol)
        {
            Console.Write(symbols[i % 4]);
        }
        else
        {
            int remaining = pauseDuration - i;
            Console.Write(remaining.ToString().PadRight(displayWidth));
        }

        // Make sure the output is displayed immediately.
        Console.Out.Flush();

        // Wait before showing the next frame.
        Thread.Sleep(delay);
    }

    // Return to the beginning of the animation.
    Console.Write(new string('\b', displayWidth));

    // Clear the spinner or finish the countdown at zero.
    if (isSymbol)
    {
        Console.Write(new string(' ', displayWidth));
    }
    else
    {
        Console.Write("0".PadRight(displayWidth));
    }
}   
    
    public void countDown()
    {
        Console.WriteLine("3");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("2");

        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("1");

        Thread.Sleep(1000);

        Console.Write("\b \b");
    }

    public virtual void DoActivity()
    {
        Console.WriteLine("Doing the activity!");
    }

    public virtual void ChangeDuration()
    {
        Console.WriteLine("Change the durations!");
    }
}