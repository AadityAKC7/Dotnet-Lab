using System;

class Number
{
    public int Value { get; set; }

    public Number(int value)
    {
        Value = value;
    }

    // Overloading the binary + operator
    public static Number operator +(Number num1, Number num2)
    {
        return new Number(num1.Value + num2.Value);
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
        Number num2 = new Number(20);

        // Using the overloaded binary + operator
        Number result = num1 + num2;
        result.Display();
    }
}