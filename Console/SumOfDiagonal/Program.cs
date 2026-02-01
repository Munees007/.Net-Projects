using System;

namespace SumOfDiagonal
{
    internal class Program
    {
        // Sum of main and secondary diagonal without double-counting middle
        public static int sumDiagonal(int[,] matrix, int row, int col)
        {
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                sum += matrix[i, i];               // Main diagonal
                sum += matrix[i, col - i - 1];     // Secondary diagonal
            }

            // If matrix has odd size, subtract the middle element once
            if (row == col && row % 2 != 0)
            {
                int mid = row / 2;
                sum -= matrix[mid, mid];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tSum of Diagonal Program");

            while (true)
            {
                Console.Write("\nEnter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = int.Parse(Console.ReadLine());

                if (rows != cols)
                {
                    Console.WriteLine("Matrix must be square for diagonal sum. Try again.");
                    continue;
                }

                int[,] matrix = new int[rows, cols];

                Console.WriteLine("\nEnter matrix elements row-wise:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int sum = sumDiagonal(matrix, rows, cols);
                Console.WriteLine($"\nSum of diagonals: {sum}");

                Console.Write("\nDo you want to enter another matrix (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
