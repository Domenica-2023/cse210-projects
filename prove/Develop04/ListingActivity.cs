//Run() : void
//GetRandomPrompt() : string
//GetListFromUser() : List<string>

using System;

namespace MindfulnessApp
{
  public class ListingActivity : Activity
  {
    
    private string _prompt = "";
    private string _list = ""; 
   
    
    public GetRandomPrompt()
    {
      return _prompt;  
    }

    public string GetListFromUser()
    {
      return _list; 
      
     }
        
    public void SetPrompt (string prompt)
     {
        	 _prompt = prompt; 
        }
        
    public void SetList (string list)
        {
        	 _list = list; 
        }
     
  }
}