class Prompts
{
    List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for?",
        "What's an important thing you learned today?",
        "What's one way you saw the hand of God helping you today?",
        "How did you show love for yourself today?",
        "How did you show love for someone else today?",
        "How did you show love for God today?"
    };

    public void DisplayPrompts()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
    public void ReturnToMenu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Press 'q' to reeturn to the menu.");
            string input = Console.ReadLine();

            if (input == "q")
            {
                done = true;
            }
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}