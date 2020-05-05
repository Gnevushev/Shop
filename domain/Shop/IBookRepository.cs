using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public interface IBookRepository
    {
        List<Book> GetAllByTitle(string titlePart);
    }
}
