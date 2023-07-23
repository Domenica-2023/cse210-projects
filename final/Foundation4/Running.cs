public class Running : Activity
{

    public Running(string date, int timeMinutes) : base (date, timeMinutes)
    {
        _date = date;
        _timeMinutes = timeMinutes;
        _distance = distance; 

    }
    public void DisplayRunning()
    {
         Console.WriteLine($"{_dayone} by: {_daytwo} // {_runninglength}");
        Console.WriteLine("RunningDistance:");
    }

}
