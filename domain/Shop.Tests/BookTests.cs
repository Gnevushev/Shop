using System;
using Xunit;

namespace Shop.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN tregeg");

            Assert.False(actual);
        }


        [Fact]
        public void IsIsbn_WithSpace_ReturnFalse()
        {
            bool actual = Book.IsIsbn(" ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_With10Isbn_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 345-673-523 2");

            Assert.True(actual);
        } 

        [Fact]
        public void IsIsbn_With13Isbn_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 345-673-522 3320");

            Assert.True(actual);
        }
    }
}
 