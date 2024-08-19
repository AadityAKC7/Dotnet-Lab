using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter time (years): ");
        double time = double.Parse(Console.ReadLine());

        Console.Write("Enter rate (% per year): ");
        double rate = double.Parse(Console.ReadLine());

        double interest = (principal * time * rate) / 100;
        Console.WriteLine("Simple Interest: " + interest);
    }
}
