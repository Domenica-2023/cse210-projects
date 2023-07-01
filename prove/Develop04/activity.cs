//DisplayStartingMessage() : void
//DisplayEndingMessage() : void
//ShowSpinner(seconds : int) : void
//ShowCountDown(second : int) : void

using System;

namespace MindfulnessApp

{
    public class Activity 

    {
        private string _name = "";
        private string _description = ""; 
        private int _duration = 0;
        private List<char> _spinner = new List<char>(){'\\', '|', '/', '-'};

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        //Getters and setters 
        public string GetName ()
        {
            return _name; 
        }

        public string GetDescription()
        {
            return _description; 
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine ($"Welcome to the {_name} program. This program will {_description}.");
            Console.WriteLine ("How long do you want to use this activity? ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine ("Get Ready...");
            ShowSpinner(5);
        }

        public void DisplayEndingMessage ()
        {
            Console.Clear();
            Console.WriteLine($"You have completed {_duration} of the {_name} activity!");
            ShowSpinner(5);
        }

        public void ShowSpinner (int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds (seconds);
            while (DateTime.now < endTime)
            {
                foreach (char c in _spinner)
                {
                    Console.Write (c);
                    Thread.Sleep (200);
                    Console.Write("\b \b");
                }
            }

        }

        public void ShowCountdown (int seconds)
        {
            for (int i = seconds; i > -1; i--)
            {
                Console.Write (i);
                Thread.Sleep (1000);
                Console.Write ("\b \b");
            }
        
        }
    }
}