using System;

namespace WelcomeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}, to dotnet technology");
            Console.ReadKey();
        }
    }
}
