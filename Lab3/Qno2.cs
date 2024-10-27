using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // List of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Aaditya", Salary = 60000, Address = "Kathmandu" },
            new Employee { Name = "Manas", Salary = 40000, Address = "Kathmandu" },
            new Employee { Name = "Janak", Salary = 52000, Address = "Pokhara" },
            new Employee { Name = "Nikesh", Salary = 70000, Address = "Kathmandu" }
        };

        // Using LINQ to select employees with salary > 50000 and address "Kathmandu"
        var filteredEmployees = employees
            .Where(emp => emp.Salary > 50000 && emp.Address == "Kathmandu");

        // Display the filtered employees
        foreach (var emp in filteredEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
        }
    }
}