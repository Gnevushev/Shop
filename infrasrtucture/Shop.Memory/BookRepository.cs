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
         
        public List<Book> GetAllByTitleOrAuthor(string fioAuthorPart)
        {
            return books.Where(x => x.Title.Contains(fioAuthorPart)).ToList();
        }

        public List<Book> GetAllByISBN(string titlePart)
        {
            return books.Where(x => x.Title.Contains(titlePart)).ToList();
        }

        
    }
}
