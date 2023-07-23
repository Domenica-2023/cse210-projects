public class Cycling : Activity
{

    public Cycling(string date, int timeMinutes) : base (date, timeMinutes)
    {
        _date = date;
        _timeMinutes = timeMinutes;
        _distance = distance; 

    }
    public Activity()
    {
        _length = 0;
        _month = 0;
        _year = 0;
        _days = 0;
        
        return new Cycling("",)
    }

}
