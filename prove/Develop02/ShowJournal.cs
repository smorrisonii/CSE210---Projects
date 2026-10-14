class ShowJournal
{
    public void DisplayJournal(List<string> journal)
    {
        foreach (string entry in journal)
        {
            Console.WriteLine(entry);
        }
    }

    public void ProceedToMenu()
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
}