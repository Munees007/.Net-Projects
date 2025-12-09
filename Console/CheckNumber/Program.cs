using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    class Program
    {
        public int Num { set; get; }
        public int Key { set; get; }
        int digit(int n)
        {
            int count = 0;
            while(n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
        bool checkNumber()
        {
            int d = digit(Key);
            int multiplyFactor = (int)Math.Pow(10, d);
            int copy = Num;
            if(d > digit(Num))
            {
                return false;
            }

            while (copy != 0)
            {
                int rem = copy % multiplyFactor;
                if(rem == Key)
                {
                    return true;
                }
                copy /= 10;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("\tCHECK THE GIVEN NUMBER IS PRESENT IN ANOTHER NUMBER OR NOT");
            while(true)
            {
                Console.Write("\nEnter a number:");
                Program pg = new Program();
                pg.Num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number to be checked:");
                pg.Key = Convert.ToInt32(Console.ReadLine());
                if (pg.checkNumber())
                {
                    Console.WriteLine($"The Given number {pg.Key} is Present in the number {pg.Num}");
                }
                else
                {
                    Console.WriteLine($"The Given number {pg.Key} is not Present in the number {pg.Num}");
                }
                Console.Write("Do you want to continue(y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Thank You");
            Console.Read();
        }
    }
}
