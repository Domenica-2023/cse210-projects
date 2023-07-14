class ChecklistGoal
{
    private int target;
    private int current;
    private int bonus;
    public SimpleGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        this.target = target;
        this.current = 0;
        this.bonus = bonus;
    }

    public SimpleGoal (string name, string description, int points, int target, int current, int bonus, bool complete) : base (name, description, points, complete)
    {
        this.target = target;
        this.current = current;
        this.bonus = bonus;
    }

    public override int RecordEvent()
    {
        Console.WriteLine ("How many times have you completed the goal?");
        int times = int.Parse(Console.ReadLine());
        current += times;
        if (current < target)
        {
            Console.WriteLine ($"Congratulations you have earned {points * times} points!");
            return points * times;
        }
        else 
        {
            complete = true;
            Console.WriteLine ($"Congratulations you have earned {(points * times) + bonus} points!");
            return (points * times) + bonus;
        }
        
    }

    public override string SaveString()
    {
        return $"SimpleGoal,{name},{description},{points},{complete}" // Change the output string to reflecta ALL the variables including the  Target, Bonus and Current
    }

    // Override the Display method
    //  $"[{GetCompleteChar()}] {name} - {description} {current}/{target}"; 
    public override ($"[{GetCompleteChar()}] {name} - {description} {current}/{target}");
}