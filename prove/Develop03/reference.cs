using System;


public class reference
{
    private int _chapter; 82
    private int _verse; 10
    private int _verse2;
    private string _book; Doctrine & Covenents

    public Reference(string book, int  chapter, int verse)
    {
        // Default to name and 2 numbers with colon // John 5:3 
        _chapter = chapter;
        _verse = verse;
        _book = book; 
        _verse2 = 0;
    }

    public Reference(string book, int chapter, int verse, int verse2)
    {
        // Default to name and 2 numbers // 5:3
        //other option is name, a number and a range
        //for example John 5:3-4
        Console.Writeline("82");
        Console.Writeline("10");
        Console.Writeline("Doctrine and Covenants");
        Console.WriteLine("0");
        Console.WriteLine("I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");

        
        _chapter = chapter;
        _verse = verse;
        _book = book;
        _verse2 = verse2;


    }


    public string GetReference()
    {
        if (_verse2 == 0)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_verse2}";
    }
}