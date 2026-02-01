using System;

namespace SumOfRowColumn
{
    enum Direction
    {
        Row,
        Column
    }

    internal class Program
    {
        public static int[] countRow_Column(int[,] matrix, int n, int m, Direction direction)
        {
            int[] result = new int[(direction == Direction.Row) ? n : m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (direction == Direction.Row)
                        result[i] += matrix[i, j];
                    else
                        result[j] += matrix[i, j];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tSum of Rows / Columns Program");

            while (true)
            {
                Console.Write("\nEnter number of rows: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int m = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, m];

                Console.WriteLine("\nEnter matrix elements row-wise:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.Write("\nDo you want to sum Rows or Columns? (R/C): ");
                string choice = Console.ReadLine().ToLower();

                Direction dir = (choice == "r") ? Direction.Row : Direction.Column;
                int[] sums = countRow_Column(matrix, n, m, dir);

                if (dir == Direction.Row)
                {
                    Console.WriteLine("\nSum of each row:");
                    for (int i = 0; i < sums.Length; i++)
                        Console.WriteLine($"Row {i + 1} sum: {sums[i]}");
                }
                else
                {
                    Console.WriteLine("\nSum of each column:");
                    for (int j = 0; j < sums.Length; j++)
                        Console.WriteLine($"Column {j + 1} sum: {sums[j]}");
                }

                Console.Write("\nDo you want to check another matrix? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
