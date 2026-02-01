using System;

namespace MinMax
{
    internal class Program
    {
        public static void findMinMax(int[] arr, out int min, out int max)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            min = arr[0];
            max = arr[0];

            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tMin-Max Finder Program");

            while (true)
            {
                Console.Write("\nEnter the number of elements: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    findMinMax(arr, out int min, out int max);
                    Console.WriteLine($"\nMinimum value: {min}");
                    Console.WriteLine($"Maximum value: {max}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("\nDo you want to check another array (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
