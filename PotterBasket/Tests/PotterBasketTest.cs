using PotterBasket;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class PotterBasketTest
    {
        [Fact]
        public void LowestPrice_CheckSimpleCartValue_ReturnsPrice()
        {
            //Arrange
            Cart cart = Cart.GetCart();
            double expected = 67.6;
            //Act
            double actual = Calculate.LowestPrice(cart);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LowestPrice_CheckWithSpecificValue_ReturnsPrice()
        {
            //Arrange
            Cart cart = new Cart();
            cart.Books = new List<Book>()
            {
                new Book("first"),
                new Book("first"),
                new Book("second"),
                new Book("second"),
                new Book("third"),
                new Book("third"),
                new Book("fourth"),
                new Book("fifth"),
            };
            double expected = 51.2;
            //Act
            double actual = Calculate.LowestPrice(cart);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsNumberBit_BitNumber_ReturnsTrue()
        {
            //Arrange
            int number = 256;
            //Act
            //Assert
            Assert.True(Calculate.IsNumberBit(number));
        }
        [Fact]
        public void IsNumberBit_NonBitNumber_ReturnsFalse()
        {
            //Arrange
            int number = 192;
            //Act
            //Assert
            Assert.False(Calculate.IsNumberBit(number));
        }
    }
}
