using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        public int Num { get; set; }
        int factorial(int n)
        {
            int c = 1;
            for(int i = 1;i<= n; i++)
            {
                c *= i;
            }
            return c;
        }
        bool isStrongNumber()
        {
            int copy = Num, res = 0;

            while(copy != 0)
            {
                int rem = copy % 10;
                res += factorial(rem);
                copy /= 10;
            }
            return Num == res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tStrong Number Checker");
            while(true)
            {
                Console.Write("\nEnter a number:");
                Program p = new Program();
                p.Num = int.Parse(Console.ReadLine());
                if (p.isStrongNumber())
                {
                    Console.WriteLine("{0} is a Strong Number", p.Num);
                }
                else 
                {
                    Console.WriteLine("{0} is not a Strong Number", p.Num);
                }
                Console.Write("\nDo you want to check another number (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Thank You");
        }
    }
}
