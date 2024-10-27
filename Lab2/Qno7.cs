using System;

class Number
{
    public int Value { get; set; }

    public Number(int value)
    {
        Value = value;
    }

    // Overloading the unary minus (-) operator
    public static Number operator -(Number num)
    {
        return new Number(-num.Value);
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Number num1 = new Number(10);
        num1.Display();

        // Using the overloaded unary minus operator
        Number num2 = -num1;
        num2.Display();
    }
}