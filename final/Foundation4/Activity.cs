public class Activity
{
    private string _date;
    private int _timeMinutes;
    private int _distance; 

    public Activity(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }


    public int GetDistance()
    {
        return _distance;
    }

    public int GetSpeed()
    {
        return _distance / _timeMinutes * 60;
    }


    public  int GetPace()
    {
        return _timeMinutes / _distance;
    }


    public  string MakeSummary();
