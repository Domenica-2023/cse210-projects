public class Event
{
    private string _title;
    private string _description;
    private string _address;
    private string _time;
    private string _date; 


    public standardDetails(string title, string description)
    {
        _title = title;
        _description = description ;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetDate()
    {
        return _date;
    }



    public string GetStandardDetails()
    {
        return _title + " - " + _description + "-" + _date + " - " + _time + "-" + _address;
    }

    public string GetFullDetails()
    {
        return _title + " - " + _description + "-" + _date + " - " + _time + "-" + _address + _typeOfEvent + " - " + _SpecificInfo +;
    }

    public string GetShortDescription()
    {
        return _typeOfEvent + " - " + _title + "-" + _date;
    }


}