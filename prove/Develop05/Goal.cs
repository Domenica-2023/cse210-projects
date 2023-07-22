abstract class Goal 
{
    protected string name;
    protected string description;
    protected int points;
    protected bool complete;

    public Goal1 (string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        complete = false;
    }

    public Goal2 (string name, string description, int points, bool complete)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.complete = complete;
    }

    public Goal3 (string name, string description, int points, bool complete)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.complete = complete;
        Console.WriteLine("Better Grades" + name + "Getting good grades is what I need to get" + description);
    }
    private char GetCompleteChar()
    {
        if (complete)
        {
            return 'X';
        }
        else
        {
            return '';
        }

    }

    public virtual string Display()
    {
        return $"[{GetCompleteChar()}] {name} - {description}"; 
    }

    // Add a getter method for the complete variable

    public abstract int RecordEvent();
    public abstract string SaveString();
}