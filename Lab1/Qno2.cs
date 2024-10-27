using System;

namespace Program1_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first, Second and Third  integer: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine("The sum is: " + sum);
        }
    }
}

