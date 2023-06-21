using System.IO;

int userChoice = Console.ReadLine (); 

string[] prompts = {"What was the best thing that happened to you today?", "What was the worst part of your day? Why?",  "What is something you are grateful for?", "How did I see the hand of the Lord in my life today?", “If I had one thing I could do over today, what would it be?”}; 

if (userChoice = 1)
{
  // block of code to write or respond to prompt

    var prompts = new[]{1,2,3,4,5,6}
    var randomPrompt = prompts[random.Next(prompts.Length)];
    Console.Write (randomPrompt);
    string entry = Console.ReadLine (); 

} 


else if (userChoice = 2) 
{
  // block of code to display saved entries 

    string filename = "journal.txt"; 
    string[] lines = System.IO.File.ReadAllLines(filename); foreach (string line in lines) 
    { 
        string[] parts = line.Split(","); 
        string dates = parts[0]; 
        string prompts = parts[1];
        string entries = parts[1];
 
    }
} 


else if (userChoice = 3) 
{
  // block of code to 
} 


else if (userChoice = 4) 
{
  // block of code to add entry to memory 

  string fileName = "journal.txt"; 
  using (StreamWriter outputFile = new StreamWriter(filename)) 

// You can add text to the file with the WriteLine method outputFile.WriteLine("This will be the first line in the file."); 
// You can use the $ and include variables just like with Console.WriteLine string color = "Blue"; outputFile.WriteLine(date + randomPrompt + answer); 
}


} 


else
{
  // block of code to leave program 

    Console.Write (“Good job writing in your journal today. Goodbye! See you soon. ”);
}





string filename = "journal.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string date = parts[0];
    string prompt = parts[1];
    string entry = parts[2];


}

DateTime theCurrentTime = DateText.Now;
string dateText = theCurrentTime.ToShortDateString();

// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

...

string fileName = "journal.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string entry = userinput;
    outputFile.WriteLine($"My favorite color is {color}");
}

String  prompt1 = “What was the best thing that happened to you today?”
String prompt2 = “What was the worst part of your day? Why?” 
String prompt3 = “What is something you are grateful for?” 
String prompt4 = 
String prompt5 = 

Console.Write (prompt1);
string answer = Console.ReadLine (); 
ConsoleWriteLine (date + prompt + answer); 
ConsoleWriteLine($“The day of your journal entry is {date}.”);
