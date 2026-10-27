
using System;
using System.Collections.Generic;

// Create and load the scripture file.
ScriptureFile scriptureFile = new ScriptureFile();
scriptureFile.CreateFile();

string[] lines = scriptureFile.LoadFile();

// Initialize the reference and scripture.
Reference reference = new Reference(lines[0]);
Scripture scripture = new Scripture(lines[1]);

// Ask the user for difficulty settings.
Difficulty difficultySettings = new Difficulty();

int difficulty = difficultySettings.SetDifficulty();
string emptySpace = difficultySettings.SetEmptySpace();

// Initialize the word-hiding system.
Word word = new Word(difficulty);

List<bool> hiddenWords = word.GetHiddenList(scripture.GetWords());

// Main memorization loop.
bool done = false;

while (!done)
{
    // Clear the console and display the scripture.
    reference.ClearConsole();

    reference.DisplayReference();
    scripture.DisplayVerse(hiddenWords, emptySpace);

    // Check if all words are hidden.
    if (word.AllWordsHidden())
    {
        Console.WriteLine();
        Console.WriteLine("Congratulations! All words are hidden!");
        done = true;
    }
    else
    {
        // Ask the user what to do next.
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");

        string userInput = Console.ReadLine() ?? "";

        if (userInput.ToLower() == "quit")
        {
            done = true;
        }
        else
        {
            // Hide more words based on the difficulty.
            word.DetermineHiddenWords();
        }
    }
}

Console.WriteLine();
Console.WriteLine("Thank you for practicing!");
