public class Lectures : Event
{
    private string _speaker;
    // Notice the syntax here that the Event constructor has 6 parameters
    // it passes 5 of the parameters to the "base" constructor, which is the "Event" class constructor.
    public Lectures(string title, string description, string date, string time, string address, string speaker)
        : base(title, description, date, time, address)
    {
        // Here we set the Lectures specific variables
        _speaker = speaker;

    }
}