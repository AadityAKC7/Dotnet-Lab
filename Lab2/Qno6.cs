using System;

class Employee
{
    public string Name;
    public int Salary;

    // Default constructor
    public Employee()
    {
        Name = "Unknown";
        Salary = 0;
    }

    // Parameterized constructor
    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    // Copy constructor
    public Employee(Employee emp)
    {
        Name = emp.Name;
        Salary = emp.Salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using default constructor
        Employee emp1 = new Employee();
        emp1.DisplayInfo();

        // Using parameterized constructor
        Employee emp2 = new Employee("John", 50000);
        emp2.DisplayInfo();

        // Using copy constructor
        Employee emp3 = new Employee(emp2);
        emp3.DisplayInfo();
    }
}