class Entry {
    private string prompt;
    private string response;
    private string date;
    // (Access Type) (Class Type) (Object Name) = new (Constructor (Parameters))
    private PromptGenerator promptGenerator = new PromptGenerator();

    public Entry () {}

    // Write
    public void Write()
    {
        date = DateTime.Now.ToShortString();
        prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        response = Console.ReadLine();
    }
    // date  = DateTime.Now.ToShortString()
    // prompt = *object name . method name()*
    // Getresponse frrom the user

    public void Display()
    {
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        Console.WriteLine(response);
    }

    // Display
    // write out each variable (prompt, response, date)
}