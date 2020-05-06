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
        public void IsIsbn_WithOkIsbn_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 34567-52321");

            Assert.True(actual);
        }
    }
}
 