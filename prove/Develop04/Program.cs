using System;

namespace MindfullnessApp
{
  class Program
  {

    static void Main(string[] args)
    {
      BreathingActivity breathingActivity = new BreathingActivity ("Breathing Activity", "help you breathe slowly and deeply while calming your nervous system. ");
      breathingActivity.RunActivity();

      // ReflectingActivity ReflectingActivity = new ReflectingActivity();
      // ReflectingActivity.SetName("Reflecting Activity");
      // ReflectingActivity.SetDescription("give you a prompt or question to reflect on and answer. ")

      // ListingActivity ListingActivity = new ListingActivity();
      // ListingActivity.SetName("Listing Activity");
      // ListingActivity.SetDescription("list as many things as you canin a certain area of strength or positivity. ")


    }

  }
}