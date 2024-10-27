using System;

class Employee
{
    // Read-write property
    public string Name { get; set; }

    // Read-only property
    public int ID { get; }

    // Write-only property
    private int _salary;
    public int Salary
    {
        set { _salary = value; }
    }

    // Constructor to initialize read-only property
    public Employee(int id)
    {
        ID = id;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Salary: {_salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(101);
        
        // Access read-write property
        emp.Name = "John";

        // Write to write-only property
        emp.Salary = 50000;

        emp.DisplayInfo();  // Displays Name, ID, and Salary
    }
}