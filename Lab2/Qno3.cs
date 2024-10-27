using System;

partial class Employee
{
    public string Name { get; set; }
}

partial class Employee
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Name = "Aaditya Khatri";
        emp.DisplayInfo();
    }
}