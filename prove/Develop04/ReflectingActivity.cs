using System;


class ReflectingActivity : Activity
{
  private Random rnd = new Random();
  private List<string> _prompt = new List<string>() {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };
  private List<string> _question = new List<string>() {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };

  public ReflectingActivity(string name, string description) : base(name, description) { }
  public void RunActivity()
  {
    DisplayStartingMessage();
    int index = rnd.Next(0, _prompt.Count);
    Console.WriteLine(_prompt[index]);
    Console.WriteLine("\nPress enter to continue...");
    string input = Console.ReadLine();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      index = rnd.Next(0, _question.Count);
      Console.WriteLine(_question[index]);
      ShowSpinner(15);
    }
    DisplayEndingMessage();
  }
}