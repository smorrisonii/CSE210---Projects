using System.Diagnostics;

class BreatheActivity : Activity
{
    public int _inDuration;
    public int _outDuration;

    Stopwatch timer = new Stopwatch();

    public BreatheActivity(int inDuration, int outDuration)
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _inDuration = inDuration;
        _outDuration = outDuration;
    }

    public override void DoActivity()
    {
        bool done = false;

        Console.Clear();

        ShowDescription();

        GetActivityDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause("symbol", _pauseDuration);

        timer.Start();

        Console.Clear();
        Console.WriteLine();
        while (!done)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
            
            if (timer.Elapsed.TotalSeconds >= _activityDuration)
            {
                timer.Stop();
                timer.Reset();
                done = true;
            }

        }

        Console.WriteLine("Well done!");
        Pause("symbol", _pauseDuration);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_name}!");
        Pause("symbol", _pauseDuration);
    }

    public void BreatheIn()
    {
        Console.Write("Breathe in... ");
        Pause("number", _inDuration);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Now breathe out... ");
        Pause("number", _outDuration);
        Console.WriteLine();
    }

    public override void ChangeDuration()
    {
        bool done = false;
        int inDuration = 0;
        int outDuration = 0;

        Console.Clear();
        Console.WriteLine($"Input the length you would like to breathe in for, in seconds:");

        while (!done)
        {
        string response = Console.ReadLine();

            try
            {
                inDuration = int.Parse(response);
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
                Console.WriteLine($"Please input a whole number.");
            }
        }

        Console.Clear();
        done = false;

                Console.WriteLine($"Input the length you would like to breathe out for, in seconds:");

        while (!done)
        {
        string response = Console.ReadLine();

            try
            {
                outDuration = int.Parse(response);
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
                Console.WriteLine($"Please input a whole number.");
            }
        }

        _inDuration = inDuration;
        _outDuration = outDuration;
    }
}