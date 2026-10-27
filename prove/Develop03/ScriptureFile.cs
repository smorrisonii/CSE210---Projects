using System;
using System.IO;

class ScriptureFile
{
    string _filePath = "scriptures.txt";

    // Create a test scripture file if one doesn't exist.
    public void CreateFile()
    {
        if (!File.Exists(_filePath))
        {
            string testScripture = "John 3:16\nFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

            File.WriteAllText(_filePath, testScripture);

            Console.WriteLine("Scripture file created!");
        }
    }

    // Load the scripture file.
    public string[] LoadFile()
    {
        if (!File.Exists(_filePath))
        {
            CreateFile();
        }

        string[] lines = File.ReadAllLines(_filePath);

        if (lines.Length < 2)
        {
            throw new InvalidDataException(
                "The scripture file must contain a reference and a verse."
            );
        }

        return lines;
    }
}