using System;

namespace CountCharacters
{
    internal class Program
    {
        public string Text { get; set; }

        public int CountCharacter(char c)
        {
            int count = 0;
            foreach (char ch in Text)
            {
                if (ch == c)
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tCharacter Count Program");

            while (true)
            {
                Program p = new Program();

                Console.Write("\nEnter a string: ");
                p.Text = Console.ReadLine();

                foreach(char ch in p.Text)
                {
                    int result = p.CountCharacter(ch);
                    Console.WriteLine("'{0}' => {1}", ch, result);
                }

                
                

                Console.Write("\nDo you want to check another string (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\nThank You");
        }
    }
}
