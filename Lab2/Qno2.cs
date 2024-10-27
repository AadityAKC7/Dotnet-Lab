using System;
using MyNamespace;

namespace MyNamespace
{
    public class Employee
    {
        public string Name { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }
    }
}

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Aaditya Khatri";
            emp.DisplayInfo();
        }
    }
}