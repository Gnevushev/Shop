using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Shop.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithValidIsbn_returnTrue()
        {
            var bookReposiroryStub = new Mock<IBookRepository>();
            bookReposiroryStub.Setup(x => x.GetAllByISBN(It.IsAny<string>())).Returns(new List<Book> { new Book(1, "", "", "") });

            bookReposiroryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(new List<Book> { new Book(2, "", "", "") });

            var bookService = new BookService(bookReposiroryStub.Object);
            var validIsbn = "ISBN 29301-33103";

            var actual = bookService.GetAllByQuery(validIsbn); 

            Assert.Collection(actual, book => Assert.Equal(1, book.Id));

        }

        [Fact]
        public void GetAllByQuery_WithInvalidIsbn_returnFalse()
        {
            var bookReposiroryStub = new Mock<IBookRepository>();
            bookReposiroryStub.Setup(x => x.GetAllByISBN(It.IsAny<string>())).Returns(new List<Book> { new Book(1, "", "", "") });

            bookReposiroryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(new List<Book> { new Book(2, "", "", "") });

            var bookService = new BookService(bookReposiroryStub.Object);
            var validIsbn = "29301-33103";

            var actual = bookService.GetAllByQuery(validIsbn);

            Assert.Collection(actual, book => Assert.Equal(2, book.Id));

        }
    }
}
