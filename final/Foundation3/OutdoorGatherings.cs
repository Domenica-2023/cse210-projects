public class OutdoorGatherings : Event
{
    private string _weather;
    private int _temp; 


    public OutdoorGatherings(string title, string addres, string date, string descriptions, string weather, int temp)
        : base()
    {
        // Here we set the Outdoor gatherings specific variables
        _weather = weather;
        _temp = temp;

    }

    public string GetWeather()
    {
    return $"The weather will be {_weather} and {_temp} degrees for the event. ";

    }

}