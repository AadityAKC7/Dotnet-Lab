using System;

class Program
{
    // Define a delegate
    public delegate void DisplayMessage();

    // Method 1
    public static void Message1()
    {
        Console.WriteLine("Hello from Message1");
    }

    // Method 2
    public static void Message2()
    {
        Console.WriteLine("Hello from Message2");
    }

    static void Main(string[] args)
    {
        // Create a multicast delegate
        DisplayMessage del = Message1;
        del += Message2; // Adding Message2 to the multicast

        // Invoke the delegate, both methods will be called
        del();
    }
}