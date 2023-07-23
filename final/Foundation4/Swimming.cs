public class Swimming : Activity 
{
    private int _numberOfLaps;

    public Circle(string date, int timeMinutes, int numberOfLaps) : base (date, timeMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    // Notice the use of the override keyword here
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
}