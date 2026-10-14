class Journal
{
    List<string> _entryList = new List<string>();

    public void GatherEntries(string entry)
    {
        _entryList.Add(entry);
    }

    public void LoadEntries(List<string> entriesFromFile)
    {
        foreach (string entry in entriesFromFile)
        {
            _entryList.Add(entry);
        }
    }

    public List<string> PassEntries()
    {
        return _entryList;
    }
}