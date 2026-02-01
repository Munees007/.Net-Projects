using System;
using System.Collections.Generic;

namespace LeapYearCalculation
{
    internal class Program
    {
        public static void splitYears(
            int[] years,
            out List<int> leapYears,
            out List<int> notLeapYears)
        {
            leapYears = new List<int>();
            notLeapYears = new List<int>();

            foreach (int year in years)
            {
                if (DateTime.IsLeapYear(year))
                    leapYears.Add(year);
                else
                    notLeapYears.Add(year);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tLeap Year Split Program");

            while (true)
            {
                Console.Write("\nEnter number of years: ");
                int n = int.Parse(Console.ReadLine());

                int[] years = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter year {i + 1}: ");
                    years[i] = int.Parse(Console.ReadLine());
                }

                splitYears(years, out List<int> leapYears, out List<int> notLeapYears);

                Console.WriteLine("\nLeap Years:");
                foreach (int y in leapYears)
                    Console.WriteLine(y);

                Console.WriteLine("\nNon-Leap Years:");
                foreach (int y in notLeapYears)
                    Console.WriteLine(y);

                Console.Write("\nDo you want to check again (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
