using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of subjects: ");
        int numSubjects = int.Parse(Console.ReadLine());

        int[] marks = new int[numSubjects];
        for (int i = 0; i < numSubjects; i++)
        {
            Console.Write($"Enter mark for subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        int min = marks[0], max = marks[0], sum = 0;
        foreach (int mark in marks)
        {
            if (mark < min) min = mark;
            if (mark > max) max = mark;
            sum += mark;
        }
        double average = (double)sum / numSubjects;

        // Display results
        Console.WriteLine($"Minimum mark: {min}");
        Console.WriteLine($"Maximum mark: {max}");
        Console.WriteLine($"Average mark: {average:F2}");
    }
}
