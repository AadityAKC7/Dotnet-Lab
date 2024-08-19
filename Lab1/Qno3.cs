using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your address: ");
        string address = Console.ReadLine();
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();
        
        Console.WriteLine("\nHere are the details you entered:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Email: " + email);
    }
}
