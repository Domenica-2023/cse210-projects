class GoalManager
{
    private List<Goal> _goals = new List<Goal>()
    {};
    private int _score = 0;

    public GoalManager()
    {}
    public void ListGoalDetails ()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.Display()}");
            counter++;

        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose one of the options.");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. LifeLong Goal");
        Console.WriteLine("3. CheckList Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the description of the goal?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
                break;
            case 2:
                LifeLongGoal goal = new LifeLongGoal(name, description, points);
                _goals.Add(goal);
                break;
            case 3:
                Console.WriteLine("What is the target amount for the goal?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points is the bonus worth?");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
                break;
        }
    }
    public void RecordEvent ()
    {
        
        // Follw the same logic as the display.
        // list all the goals with a number
        // capture the user choice (represent the index position of the goal in the goals list)
        //          _goals index:   0   1   2   3   4   ...
        //          printed number: 1   2   3   4   5   ...
        // check if the goal is completed ( if( _goals[choice - 1].GetComplete() ) )
        // if the goal is complete then we state the goal is already completd
        // ese we execute the RecordEvent method ( _goals[choice - 1].RecordEvent() )
    }

    public void SaveGoals ()
    {

    }

    public void LoadGoals ()
    {

    }
}