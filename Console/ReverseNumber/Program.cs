using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        public int Num { set; get; }

        int reverseInt()
        {
            int copy = Num,res = 0;
            while(copy != 0)
            {
                res = res * 10 + (copy % 10);
                copy /= 10;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("\n\tREVERSE A GIVEN NUMBER");
            while(true)
            {
                Program pg = new Program();
                Console.Write("\nEnter a number: ");
                pg.Num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Reverse of the Given Number {pg.Num} = " + pg.reverseInt());
                if(Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Thank You");
            Console.Read();
        }
    }
}
