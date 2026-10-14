using System.Text.Json;

class SaveAndLoad
{
    public void Save(List<string> entries, string filename)
    {
        string json = JsonSerializer.Serialize(entries);
        File.WriteAllText(filename, json);

        Console.WriteLine("File Saved!");
    }

    public List<string> Load(string filename)
    {
        string json = File.ReadAllText(filename);

        Console.WriteLine("File Loaded!");
        Console.WriteLine("You can see all of your entries by selecting");
        Console.WriteLine("'View Journal Prompts' in the menu!");
        
        return JsonSerializer.Deserialize<List<string>>(json)
            ?? new List<string>();
    }
}