using System.Diagnostics;

class ListenActivity : Activity
{
    List<string> _prompts;
    int _responseCount;

    Random random = new Random();
    Stopwatch timer = new Stopwatch();

    public ListenActivity(List<string> prompts, int responseCount)
    : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = prompts;
        _responseCount = responseCount;
    }

    public override void DoActivity()
    {
        bool done = false;
        _responseCount = 0;

        Console.Clear();

        ShowDescription();

        GetActivityDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause("symbol", _pauseDuration);

        Console.Clear();

        ShowPrompt();

        timer.Start();

        while (!done)
        {
            GetResponse();

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

    public void ShowPrompt()
    {
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        Console.WriteLine("List as many responses as you'd like to the following prompt:");
        Console.WriteLine($" --- {selectedPrompt} --- ");
        Console.Write("You may begin in...");
        Pause("number", _pauseDuration);
        Console.WriteLine();
    }

    public void GetResponse()
    {
        Console.Write("> ");
        Console.ReadLine();
        _responseCount += 1;
    }
}