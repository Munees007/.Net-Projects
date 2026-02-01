using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Modals;

namespace LibraryManagement.Services
{
    interface ILibraryStorage
    {
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);

        void AddBook(Book book);

        void BorrowBook(int memberId, int bookId);
        void ReturnBook(int memberId, int bookId);

        List<Member> GetMembers();
        List<Book> GetBooks();
    }
    internal class LibraryStorage : ILibraryStorage
    {
        private const string MEMBER_FILE = "Members.dat";
        private const string BOOK_FILE = "Books.dat";
        private const string BORROW_FILE = "Borrow.dat";

        private List<T> Load<T>(string file)
        {
            if (!File.Exists(file))
                return new List<T>();

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                return (List<T>)bf.Deserialize(fs);
            }
        }

        private void Save<T>(string file, List<T> data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                bf.Serialize(fs, data);
            }
        }

        // ================= MEMBERS =================
        public void AddMember(Member member)
        {
            var members = Load<Member>(MEMBER_FILE);
            members.Add(member);
            Save(MEMBER_FILE, members);
        }

        public void UpdateMember(Member member)
        {
            var members = Load<Member>(MEMBER_FILE);
            var m = members.FirstOrDefault(x => x.MemberID == member.MemberID);
            if (m != null)
                m.MemberName = member.MemberName;

            Save(MEMBER_FILE, members);
        }

        public void DeleteMember(int memberId)
        {
            var members = Load<Member>(MEMBER_FILE);
            members.RemoveAll(m => m.MemberID == memberId);
            Save(MEMBER_FILE, members);
        }

        // ================= BOOKS =================
        public void AddBook(Book book)
        {
            var books = Load<Book>(BOOK_FILE);
            book.AvailableCopies = book.TotalCopies;
            books.Add(book);
            Save(BOOK_FILE, books);
        }

        // ================= BORROW / RETURN =================
        public void BorrowBook(int memberId, int bookId)
        {
            var books = Load<Book>(BOOK_FILE);
            var borrows = Load<BorrowRecord>(BORROW_FILE);

            var book = books.FirstOrDefault(b => b.BookID == bookId);
            if (book == null || book.AvailableCopies == 0)
            {
                Console.WriteLine("Book not available");
                return;
            }

            book.AvailableCopies--;

            borrows.Add(new BorrowRecord
            {
                MemberID = memberId,
                BookID = bookId,
                BorrowDate = DateTime.Now
            });

            Save(BOOK_FILE, books);
            Save(BORROW_FILE, borrows);
        }

        public void ReturnBook(int memberId, int bookId)
        {
            var books = Load<Book>(BOOK_FILE);
            var borrows = Load<BorrowRecord>(BORROW_FILE);

            var record = borrows.FirstOrDefault(b => b.MemberID == memberId && b.BookID == bookId);
            if (record == null)
            {
                Console.WriteLine("No borrow record found");
                return;
            }

            borrows.Remove(record);

            var book = books.First(b => b.BookID == bookId);
            book.AvailableCopies++;

            Save(BOOK_FILE, books);
            Save(BORROW_FILE, borrows);
        }

        public List<Member> GetMembers() => Load<Member>(MEMBER_FILE);
        public List<Book> GetBooks() => Load<Book>(BOOK_FILE);
    }
}
