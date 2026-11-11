using System.Diagnostics;

class ReflectActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;
    int _questionDuration;

    Random random = new Random();
    Stopwatch timer = new Stopwatch();

    public ReflectActivity(
        List<string> prompts,
        List<string> questions,
        int questionDuration
    )
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = prompts;
        _questions = questions;
        _questionDuration = questionDuration;
    }

    public override void DoActivity()
    {
        bool done = false;

        Console.Clear();

        ShowDescription();

        GetActivityDuration();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        Pause("symbol", _pauseDuration);

        ShowPrompt();

        Console.Clear();

        timer.Start();

        while (!done)
        {
            ShowQuestion();

            if (timer.Elapsed.TotalSeconds >= _activityDuration)
            {
                timer.Stop();
                timer.Reset();
                done = true;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Pause("symbol", _pauseDuration);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_name}!");
        Pause("symbol", _pauseDuration);
    }

    public void ShowPrompt()
    {
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {selectedPrompt} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Pause("number", _pauseDuration);
        Console.WriteLine();
    }

    public void ShowQuestion()
    {
        int index = random.Next(_questions.Count);
        string selectedQuestion = _questions[index];

        Console.Write($"> {selectedQuestion} ");
        Pause("symbol", _questionDuration);
        Console.WriteLine();
    }

    public override void ChangeDuration()
    {
        bool done = false;
        int duration = 5;

        Console.Clear();

        Console.WriteLine($"Input the length you would like to ponder over the questions for, in seconds:");

        while (!done)
        {
        string response = Console.ReadLine();

            try
            {
                duration = int.Parse(response);
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

        _questionDuration = duration;
    }
}