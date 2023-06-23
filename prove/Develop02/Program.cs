using System;

class Program
{
    static void Main(string[] args)
    {
        // create journal class object
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        int userChoice = Console.ReadLine();
        //  Switch userinput
        //      Case "1"
        //          execute journal.Write()
        //      Case "2"
        //          execute journal.Display()
        //      ... same for save and load
    }
}