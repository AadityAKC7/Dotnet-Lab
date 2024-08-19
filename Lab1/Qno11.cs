using System;

class Program
{
    static void Main()
    {
        int size = 3;

        int[,] matrixA = new int[size, size];
        int[,] matrixB = new int[size, size];
        int[,] resultMatrix = new int[size, size];

        Console.WriteLine("Enter elements for Matrix A (3x3):");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                matrixA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements for Matrix B (3x3):");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                matrixB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < size; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        Console.WriteLine("Result of Matrix Multiplication:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
