using System;

class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string email, decimal salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }

    public void Info()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}, Salary: {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Aaditya Khatri", "akaaditya77@gmail.com", 60000);
        emp.Info();
    }
}