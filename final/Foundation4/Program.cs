class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Activity" objects. That means
        // you can put any Activity objects in there, and also, any object where
        // the class inherits from Activity
        List<Activity> activities = new List<Activity>();

        indoorCyling a1 = new indoorCycling("August 3rd", 30);
        activities.Add(a1);

        swimming a2 = new swimming("August 5th", 60, 100);
        activities.Add(a2);

        running a3 = new running("August 6th", 20);
        activities.Add(a3);

        foreach (Activity a in activities)
        {
            // Notice that all activities have a GetSpeed and GetPace method

            int speed = a.GetSpeed(); 

            int pace = a.GetPace(); 

            // Notice that all activities have a GetDistance method, but the behavior is
            // different forswimming
            int distance = a.GetDistance();

            string summary =a.MakeSummary;

            Console.WriteLine($"In this activity, you completed {distance} miles in {timeMinutes} minutes. That put you at a pace of {pace} miles per minute. Your speed was {speed} miles per hour. Keep up the good work!");


        }
    }
} 