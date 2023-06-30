using System;

namespace MindfullnessApp
{
  class Program
  {

    static void Main(string[] args)
    {
      Activity BreathingActivity = new Activity();
      BreathingActivity.SetName("Breathing Activity");
      BreathingActivity.SetDescription("help you breathe slowly and deeply while calming your nervous system. ")

       ReflectingActivity ReflectingActivity = new ReflectingActivity();
      ReflectingActivity.SetName("Reflecting Activity");
      ReflectingActivity.SetDescription("give you a prompt or question to reflect on and answer. ")

       ListingActivity ListingActivity = new ListingActivity();
      ListingActivity.SetName("Listing Activity");
      ListingActivity.SetDescription("list as many things as you canin a certain area of strength or positivity. ")


    }

  }
}