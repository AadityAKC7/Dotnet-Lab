using System;

// Define a custom exception by inheriting from Exception class
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void CheckAge(int age)
    {
        // Throw custom exception if the age is less than 18
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or older.");
        }
        else
        {
            Console.WriteLine("Valid age.");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}