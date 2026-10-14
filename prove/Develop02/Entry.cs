class Entry
{
    // Create mumber variables.
    string _date;
    string _prompt;
    string _response;

    public void CreateEntry()
    {
        // Get the date from the user.
        Console.WriteLine("Please insert the date:");
        _date = Console.ReadLine();

        // Get the prompt
        Prompts prompts = new Prompts();
        _prompt = prompts.GetRandomPrompt();

        // Get the response from the user.
        Console.WriteLine("Please insert your response to the prompt:");
        Console.WriteLine();
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }
    
    public string OrganizeEntry()
    {   
        // Return the entry as a string.
        return $"{_date}\n{_prompt}\n{_response}\n";
    }
}