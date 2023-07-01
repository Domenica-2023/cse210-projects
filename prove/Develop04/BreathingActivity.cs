using System;

namespace MindfulnessApp
{
  public class BreathingActivity : Activity
  {

    public void RunActivity()
    {
      DisplayStartingMessage();
      DateTime endTime = DateTime.Now.AddSeconds (_duration);
      while (datetime.now < endtime)
      {
        Console.WriteLine ("Breathe in");
        ShowCountdown (5);
        Console.WriteLine ("Breathe out");
        ShowCountdown (5);
      }

      DisplayEndingMessage();
      
    }
  }
}