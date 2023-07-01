// Run() : void
// GetRandomPrompt() : string
//GetRandomQuestion() : string
//DisplayPrompt() : void
//DisplayQuestions() : void

using System;

namespace MindfulnessApp
{
  public class ReflectingActivity : Activity
  {

    private string _prompt = "";
    private string _question = "";

    public string GetRandomPrompt();
      {
      return _prompt
      }

    public string GetRandomQuestion();
    {
      return _question
    }

    public void SetPrompt (string prompt);
    {
             _prompt = prompt;
    }

    public void SetName (string question);
        {
             _question = question; 
        }
  }
}