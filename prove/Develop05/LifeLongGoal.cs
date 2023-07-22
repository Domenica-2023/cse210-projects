class LifeLongGoal 
{
    public LifeLongGoal (string name, string description, int points) : base (name, description, points)
    {
        private string 
    }

    public override int RecordEvent()
    {
        Console.WriteLine ($"Congratulations you have earned {points} points!");
        return points;
    }

    public override string SaveString()
    {
        return $"LifeLongGoal,{name},{description},{points}"
    }
}