using System;

namespace Shop
{
    public class Book
    {
        public int Id { get; set; }

        public string Isbn { get; set; }

        public string Title { get; set; }

        public string FIO_author { get; set; }

         
        public Book(int id, string Isbn, string title, string fioAuthor)
        {
            Id = id;
            Title = title;
            FIO_author = fioAuthor;
        }

        internal static bool IsIsbn(string isbn)
        {
            return false;
        }
    }
}
 