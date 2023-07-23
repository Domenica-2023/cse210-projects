using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is the chapter of the scripture?");
        string first = Console.ReadLine();

        Console.Write("What is the verse?");
        string last = Console.ReadLine();

         Console.WriteLine($"The scripture you picked was {chapter} {verse}.");
    }
}