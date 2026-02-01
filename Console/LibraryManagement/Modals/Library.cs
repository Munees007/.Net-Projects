using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Modals
{
    [Serializable]
    internal class BorrowRecord
    {
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
    }
    [Serializable]
    internal class Library
    {
        public List<Member> Members { get; set; } = new List<Member>();
        public List<Book> Books { get; set; } = new List<Book>();
        public List<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    }
}
