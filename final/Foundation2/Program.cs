using System;

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order();
        Console.WriteLine(o1.GetTotalPrice());
        Console.WriteLine(o1.MakeShippingLabel());
        Console.WriteLine(o1.MakePackingLabel());

        Order o2 = new Order();
        Console.WriteLine(o2.GetTotalPrice());
        Console.WriteLine(o2.MakeShippingLabel());
        Console.WriteLine(o2.MakePackingLabel());

        Order o3 = new Order();
        Console.WriteLine(o3.GetTotalPrice());
        Console.WriteLine(o3.MakeShippingLabel());
        Console.WriteLine(o3.MakePackingLabel());
    }

}