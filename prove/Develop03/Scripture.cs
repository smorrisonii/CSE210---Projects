class Scripture
{
    string _verse;

    // Initialize the scripture.
    public Scripture(string verse)
    {
        _verse = verse;
    }

    public void DisplayVerse(List<bool> hiddenWords, string emptySpace)
    {
        string[] currentVerse = _verse.Split(' ');

        int timesIterated = 0;

        foreach (string word in currentVerse)
        {
            if (hiddenWords[timesIterated] == false)
            {
                string emptyWord = "";

                foreach (char letter in word)
                {
                    emptyWord += emptySpace;
                }

                currentVerse[timesIterated] = emptyWord;
            }

            timesIterated += 1;
        }

        Console.WriteLine(string.Join(" ", currentVerse));
    }

    // Return the original words for the Word class.
    public string[] GetWords()
    {
        return _verse.Split(' ');
    }
}