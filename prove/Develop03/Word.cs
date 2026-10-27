class Word
{
    List<bool> _hiddenWords = new List<bool>();
    int _difficulty;

    // Initialize the difficulty.
    public Word(int difficulty)
    {
        if (difficulty <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(difficulty));
        }

        _difficulty = difficulty;
    }

    // Create a list of booleans matching the number of words.
    public List<bool> GetHiddenList(string[] words)
    {
        _hiddenWords = new List<bool>();

        foreach (string word in words)
        {
            _hiddenWords.Add(true);
        }

        return _hiddenWords;
    }

    // Randomly hide one visible word from each group.
    public void DetermineHiddenWords()
    {
        Random random = new Random();

        for (int i = 0; i < _hiddenWords.Count; i += _difficulty)
        {
            int groupEnd = Math.Min(i + _difficulty, _hiddenWords.Count);

            List<int> visibleIndices = new List<int>();

            // Find visible words in this group.
            for (int j = i; j < groupEnd; j++)
            {
                if (_hiddenWords[j])
                {
                    visibleIndices.Add(j);
                }
            }

            // Hide one random visible word in this group.
            if (visibleIndices.Count > 0)
            {
                int randomIndex = random.Next(visibleIndices.Count);
                int wordToHide = visibleIndices[randomIndex];

                _hiddenWords[wordToHide] = false;
            }
        }
    }

    // Check whether every word is hidden.
    public bool AllWordsHidden()
    {
        foreach (bool word in _hiddenWords)
        {
            if (word == true)
            {
                return false;
            }
        }

        return true;
    }
}