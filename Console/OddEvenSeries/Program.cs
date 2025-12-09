using System;

namespace OddEvenSeries
{
    enum SeriesType
    {
        Odd,
        Even
    }
    class Program
    {

        public void PrintSeries(int start,int end,SeriesType type)
        {
            Console.WriteLine($"Printing {type} numbers from {start} to {end}:");
            start = (type == SeriesType.Odd) ? (start % 2 == 0 ? start + 1 : start) :
                (start % 2 == 0 ? start : start + 1);
            for (int i = start;i<=end; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tOdd and Even Number Series Printer");
            while (true)
            {
                
                Console.Write("Enter the start number:");
                int start = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the end number:");
                int end = int.Parse(Console.ReadLine());
                Program program = new Program();
                program.PrintSeries(start, end, SeriesType.Odd);
                program.PrintSeries(start, end, SeriesType.Even);
                Console.Write("\nDo you want to continue? (y/n):");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Thank you"); 
            Console.Read();
        }
    }
}
