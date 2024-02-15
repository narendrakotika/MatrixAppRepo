// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    static void Main()
    {
        Random random = new Random();
        int rows = 5; // Number of rows in the matrix
        int columns = 5; // Number of columns in the matrix

        int[,] matrix = new int[rows, columns];

        // Fill the matrix with random numbers
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 100); // Generates random numbers between 1 and 99
            }
        }

        // Print the matrix
        Console.WriteLine("Random Matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

