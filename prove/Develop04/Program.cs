using System;


class Program
{

  static void Main(string[] args)
  {
    List <int> log = new List<int>() {0, 0, 0};
    while (true)
    {
      Console.Clear();
      Console.WriteLine(
        "Welcome to the Activity program!\n" +
        "Times completed:\n" +
        $"\tBreathing: {log[0]}\n" +
        $"\tReflecting: {log[1]}\n" +
        $"\tListing: {log[2]}\n" +
        "1. Breathing Activity\n" +
        "2. Reflecting Activity\n" +
        "3. Listing Activity\n" +
        "4. Quit\n"
      );

      string input = Console.ReadLine();
      switch (input)
      {
        case "1":
          BreathingActivity breathingActivity = new BreathingActivity("Breathing", "help you breathe slowly and deeply while calming your nervous system. ");
          breathingActivity.RunActivity();
          log [0] ++;
          break;

        case "2":
          ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "give you a prompt or question to reflect on and answer. ");
          reflectingActivity.RunActivity();
          log [1] ++;
          break;

        case "3":
          ListingActivity listingActivity = new ListingActivity("Listing", "list as many things as you canin a certain area of strength or positivity. ");
          listingActivity.RunActivity();
          log [2] ++;
          break;  

        case "4":
          Environment.Exit(0);
          break;

      }
    }

  }

}
