using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {

        private readonly List<Book> books = new List<Book> { 
            new Book(1, "Тихий Дон"),
            new Book(2, "Мартин Иден"),
            new Book(3, "Таинсвенный остров")
        };

 
        public List<Book> GetAllByTitle(string titlePart)
        {
            return books.Where(x => x.Title.Contains(titlePart)).ToList();
        }
    }
}
 