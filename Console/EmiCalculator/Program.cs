using System;

namespace EmiCalculator
{
    internal class Program
    {
        // Function to calculate EMI
        public static double CalculateEMI(double principal, double annualRate, int months)
        {
            double monthlyRate = annualRate / (12 * 100); // Convert annual rate to monthly fraction
            double emi = principal * monthlyRate * Math.Pow(1 + monthlyRate, months) /
                         (Math.Pow(1 + monthlyRate, months) - 1);
            return emi;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tEMI Calculator");

            while (true)
            {
                Console.Write("\nEnter Principal Amount: ");
                double principal = double.Parse(Console.ReadLine());

                Console.Write("Enter Annual Interest Rate (in %): ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Enter Loan Tenure (in months): ");
                int months = int.Parse(Console.ReadLine());

                double emi = CalculateEMI(principal, rate, months);
                Console.WriteLine($"\nYour EMI is: {emi:F2}");

                Console.Write("\nDo you want to calculate another EMI? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
