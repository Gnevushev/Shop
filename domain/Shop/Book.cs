using System;

namespace Shop
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public Book(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
 