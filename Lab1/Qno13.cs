using System;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Hello", "world", "from", "C#", "!" };

        string result = string.Join(" ", stringArray);

        Console.WriteLine("Resulting string: " + result);
    }
}
