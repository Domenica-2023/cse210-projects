using System;

public class Comment
{
    public string _commentAuthor;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"{commentText} written by ({_commentAuthor}) ");
    }
}ft