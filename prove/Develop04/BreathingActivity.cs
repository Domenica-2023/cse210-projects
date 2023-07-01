using System;

class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description) : base(name, description) { }

  public void RunActivity()
  {
    DisplayStartingMessage();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      Console.WriteLine("Breathe in");
      ShowCountdown(5);
      Console.WriteLine("Breathe out");
      ShowCountdown(5);
    }

    DisplayEndingMessage();

  }
}
