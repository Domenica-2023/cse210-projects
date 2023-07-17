public class Receptions : Event
{
    private string _names;
    private int _numberPeopleAttending;
    // Notice the syntax here that the Receptions constructor has 7 parameters and then
    // it passes 5 of them directly to the "base" constructor, which is the "Event" class constructor.
    public Receptions(string title, string description, string date, string time, string address, string names int numberPeopleAttending)
        : base(title, date, description, time, address)
    {
        // Here we set any variables specific to the Receptions class
        _names = names;
        numberPeopleAttending = numberPeopleAttending
    }

    public string RSVP()
    {
        // Notice that we are calling the getter here because  is private in the base class
        string title = GetTitle();
        return $"{_numberPeopleAttending} people will be attending and their name(s) are {names}";
    }
}