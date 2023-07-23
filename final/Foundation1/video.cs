using System;

public class Video
{
    public string _videoAuthor;
    public string _videoTitle;
    public int _lengthInSeconds; 

    // Make sure to initialize your list to a new List before you use it.
    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_videoTitle} by: {_videoAuthor} // {_lengthInSeconds}");
        Console.WriteLine("Comments:");

        // Notice the use of the custom data type "Comment" in this loop
        foreach (Comment comment in _comments)
        {
            // This calls the Display method on each comment
            comment.Display();
        }
    }


    public ReturnNumberOfComments(Comments)
    {
        int numberComments = Comments.Length;
        return numberComments
    }

}

