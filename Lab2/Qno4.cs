using System;

// Single Inheritance
class Person
{
    public string Name { get; set; }
    public void ShowName()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

// Multilevel Inheritance
class Employee : Person
{
    public int Salary { get; set; }
    public void ShowSalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }
}

// Hierarchical Inheritance
class Manager : Employee
{
    public string Department { get; set; }
    public void ShowDepartment()
    {
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single and Multilevel Inheritance
        Employee emp = new Employee();
        emp.Name = "Aaditya";
        emp.Salary = 50000;
        emp.ShowName();
        emp.ShowSalary();
        
        // Hierarchical Inheritance
        Manager mgr = new Manager();
        mgr.Name = "Manas";
        mgr.Salary = 80000;
        mgr.Department = "HR";
        mgr.ShowName();
        mgr.ShowSalary();
        mgr.ShowDepartment();
    }
}