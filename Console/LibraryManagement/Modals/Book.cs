using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Modals
{
    [Serializable]
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; } = string.Empty;
    }
    [Serializable]
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; } = string.Empty;
        public Author BookAuthor { get; set; } = new Author();

        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}
