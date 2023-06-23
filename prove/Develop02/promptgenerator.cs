using System;

class PromptGenerator
{
    // ATTRIBUTES (Variables)(Fields)

    //  0   1   2   3   4
    // elem elem
    private List<string> prompts = new List<string>()
    {
        "What was the best thing that happened to you today?",
        "What was the worst part of your day? Why?", 
        "What is something you are grateful for?",
        "How did I see the hand of the Lord in my life today?", 
        "If I had one thing I could do over today, what would it be?"
    };
    private Random rnd = new Random();

   // CONSTRUCTORS (Special methods, called only once when the object is created)
   // (Access Type) (Name *Always the same as the class name*) (Paramters) {}
    public PromptGenerator(){}

    // METHO DS (Functions) (Behaviors)
    // (Access Type) (Return Type) (Name) (Parameters) {}
    public string GetPrompt ()
    {
        int index = rnd.Next(prompts.Count);
        return prompts[index];
    }

}