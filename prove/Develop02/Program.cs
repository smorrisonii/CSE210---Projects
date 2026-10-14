using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a sentinel variable. 
        bool done = false;

        // Create objects for the journal.
        Journal journal = new Journal();
        Menu menu = new Menu();
        SaveAndLoad saveAndLoad = new SaveAndLoad();
        Prompts prompts = new Prompts();
        ShowJournal showJournal = new ShowJournal();

        Console.WriteLine("Welcome to your journal app!");

        while (!done)
        {
            menu.DisplayOptions();
            int choice = menu.GetInput();

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry();

                    entry.CreateEntry();

                    string newEntry = entry.OrganizeEntry();
                    journal.GatherEntries(newEntry);

                    break;

                case 2:
                    showJournal.DisplayJournal(journal.PassEntries());
                    showJournal.ProceedToMenu();

                    break;

                case 3:
                    saveAndLoad.Save(journal.PassEntries(), "journal.json");

                    break;

                case 4:
                    if (File.Exists("journal.json"))
                    {
                        journal.LoadEntries(saveAndLoad.Load("journal.json"));
                    }
                    else
                    {
                        Console.WriteLine("No saved journal was found.");
                    }

                    break;

                case 5:
                    prompts.DisplayPrompts();
                    prompts.ReturnToMenu();

                    break;

                case 6:
                    Console.WriteLine("Thanks for using the journal!");

                    done = true;

                    break;
            }
        }
    }
}