using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
   public class BookService
    {

        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))
            {
                return bookRepository.GetAllByISBN(query);
            }
            else return bookRepository.GetAllByTitleOrAuthor(query);

        }
    }
}
