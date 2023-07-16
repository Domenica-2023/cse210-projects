using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
  
  
  	public ReturnNumberOfComments()
    {
        
    }
    

    public void Display()
    {
        Console.WriteLine($"{_title} by ({_author})-{_lengthInSeconds} seconds");
    }
}