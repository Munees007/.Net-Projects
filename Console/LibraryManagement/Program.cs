using LibraryManagement.Modals;
using LibraryManagement.Services;
using System;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryStorage lib = new LibraryStorage();

            while (true)
            {
                Console.WriteLine("\n--- LIBRARY MANAGEMENT ---");
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. View Books");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Member ID: ");
                        int mid = int.Parse(Console.ReadLine());
                        Console.Write("Member Name: ");
                        string mname = Console.ReadLine();
                        lib.AddMember(new Member { MemberID = mid, MemberName = mname });
                        break;

                    case 2:
                        Console.Write("Book ID: ");
                        int bid = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Total Copies: ");
                        int count = int.Parse(Console.ReadLine());
                        lib.AddBook(new Book { BookID = bid, Title = title, TotalCopies = count });
                        break;

                    case 3:
                        Console.Write("Member ID: ");
                        mid = int.Parse(Console.ReadLine());
                        Console.Write("Book ID: ");
                        bid = int.Parse(Console.ReadLine());
                        lib.BorrowBook(mid, bid);
                        break;

                    case 4:
                        Console.Write("Member ID: ");
                        mid = int.Parse(Console.ReadLine());
                        Console.Write("Book ID: ");
                        bid = int.Parse(Console.ReadLine());
                        lib.ReturnBook(mid, bid);
                        break;

                    case 5:
                        foreach (var b in lib.GetBooks())
                        {
                            Console.WriteLine($"{b.BookID} | {b.Title} | Available: {b.AvailableCopies}/{b.TotalCopies}");
                        }
                        break;

                    case 0:
                        return;
                }
            }
        }
    }
}
