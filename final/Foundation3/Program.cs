using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Event" object
        Event e1 = new Event("", "");
        Console.WriteLine(a1.GetFullDetails());

        // Now create the derived class assignments
       Receptions e2 = new Receptions("", "", "", "");
        Console.WriteLine(a2.GetFullDetails());
        Console.WriteLine(a2.GetShortDescription());
        Console.WriteLine(a2.GetStandardDetails());

        Lectures e3 = new Lectures("", "", "");
        Console.WriteLine(a3.GetFullDetails());
        Console.WriteLine(a3.GetShortDescription());
        Console.WriteLine(a3.GetStandardDetails());

        OutdoorGatherings e4 = new OutdoorGatherings("Flower Display", "", "sunny", 78);
        Console.WriteLine(a3.GetFullDetails());
        Console.WriteLine(a3.GetShortDescription());
        Console.WriteLine(a3.GetStandardDetails()); 
    }
}