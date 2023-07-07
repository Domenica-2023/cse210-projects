class SimpleGoal
{
    public SimpleGoal (string name, string description, int points) : base (name, description, points)
    {}

    public SimpleGoal (string name, string description, int points, bool complete) : base (name, description, points, complete)
    {}

    public override int RecordEvent()
    {
        complete = true;
        Console.WriteLine ($"Congratulations you have earned {points} points!");
        return points;
    }

    public override string SaveString()
    {
        return $"SimpleGoal,{name},{description},{points},{complete}"
    }

}