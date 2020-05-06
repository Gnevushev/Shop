using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {

        private readonly List<Book> books = new List<Book>
        {
            new Book(1, "ISBN 12345-09876", "Мастер и Маргарита", "Достоевский Федор Михайлович"),
            new Book(2, "ISBN 54321-67890", "Мартин Иден", "Джек Лондон"),
            new Book(3, "ISBN 11223-66778", "Таинсвенный остров", "Жюль Верн")

        };
         
        public List<Book> GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.FIO_author.Contains(query) || book.Title.Contains(query)).ToList();
        }

        public List<Book> GetAllByISBN(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToList();
        }

        
    }
}
