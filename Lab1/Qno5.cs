using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        if (op == '+')
            result = num1 + num2;
        else if (op == '-')
            result = num1 - num2;
        else if (op == '*')
            result = num1 * num2;
        else if (op == '/')
        {
            result = num1 / num2;
        }
        else
            Console.WriteLine("Error: Invalid operator.");

        if (op == '+' || op == '-' || op == '*' || (op == '/' && num2 != 0))
            Console.WriteLine("Result: " + result);
    }
}
