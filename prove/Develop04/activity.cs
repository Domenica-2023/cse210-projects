//DisplayStartingMessage() : void
//DisplayEndingMessage() : void
//ShowSpinner(seconds : int) : void
//ShowCountDown(second : int) : void

using system;

namespace MindfulnessApp

{
    public class Activity 

    {
        private string _name = "";
        private string _description = ""; 
        private int _duration = 0;
        // spinner. create a list to store the spinner characters. ['\', '|', '/', '-']

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
            Console.WriteLine ($"Welcome to the {_name} program. This program will {_description}.");
            Console.WriteLine ("How long do you want to use this activity? ");
            _duration = Console.ReadLine();
            // print "Get Ready..."
            // Display spinner
        }

        public void DisplayEndingMessage ()
        {
            return $"Thank you for using the {_name} program. See you next time. Bye!" ; // also state how many seconds of the activity they completed
        }

        public void ShowSpinner (int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds (seconds);
            // while datetime.now < endtime
            //      for character in spinner
            //          print character
            //          Thread.Sleep(200)
            //          Console.WriteLine("\b \b")

        }

        public void ShowCountdown (int seconds)
        {
            
            //      for(int i = seconds; i >= 0; i--)
            //          print i
            //          Thread.Sleep(1000)
            //          Console.WriteLine("\b \b")
        }
    }
}