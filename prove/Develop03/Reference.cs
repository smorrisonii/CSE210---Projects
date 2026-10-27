// Define the class as "Reference."
class Reference
{
    // Create a member variable for the reference.
    string _reference;

    // Initialize the reference.
    public Reference(string reference)
    {
        _reference = reference;
    }

    // Clear the console.
    public void ClearConsole()
    {
        Console.Clear();
    }

    // Display the reference.
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
}