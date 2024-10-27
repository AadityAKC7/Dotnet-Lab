using System;

class Shape
{
    public int Length { get; set; }
    public int Breadth { get; set; }

    // Default constructor
    public Shape()
    {
        Length = 0;
        Breadth = 0;
    }

    // Parameterized constructor
    public Shape(int length, int breadth)
    {
        Length = length;
        Breadth = breadth;
    }
}

class Rectangle : Shape
{
    // Constructor that uses the base class constructor
    public Rectangle(int length, int breadth) : base(length, breadth) { }

    public int CalculateArea()
    {
        return Length * Breadth;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a rectangle object using parameterized constructor
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine($"Area of Rectangle: {rect.CalculateArea()}");
    }
}