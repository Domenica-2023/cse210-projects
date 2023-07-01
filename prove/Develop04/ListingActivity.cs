using System;


class ListingActivity : Activity
{
  private List<string> _prompts = new List<string>() {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };
  private Random rnd = new Random();

  public ListingActivity(string name, string description) : base(name, description) { }
  public void RunActivity()
  {
    DisplayStartingMessage();
    int index = rnd.Next(0, _prompts.Count);
    Console.WriteLine(_prompts[index]);
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    int counter = 0;
    while (DateTime.Now < endTime)
    {
      string input = Console.ReadLine();
      counter++;
    }
    Console.WriteLine($"You entered {counter.ToString()} items");
    ShowSpinner(5);
    DisplayEndingMessage();
  }
}
