using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StringCalculator;

namespace Tests
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_PositiveNumbers_ReturnsTrue()
        {
            //Arrange
            string number = "2,3";
            string expected = "5";
            //Act
            string actual = StringCalculator.StringCalculator.Add(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_PositiveDecimalNumbers_ReturnsTrue()
        {
            //Arrange
            string number = "2.2,4.1";
            string expected = "6.3";
            //Act
            string actual = StringCalculator.StringCalculator.Add(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            //Arrange
            string number = "";
            string expected = "0";
            //Act
            string actual = StringCalculator.StringCalculator.Add(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc,asd")]
        [InlineData(",")]
        [InlineData("   ,2")]
        public void Add_NotANumberValue_Exception(string number)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<Exception>(() => StringCalculator.StringCalculator.Add(number));
        }

        [Fact]
        public void Add_MissingValueOnLastPosition_InvalidOperationException()
        {
            //Arrange
            string number = "4,5,";
            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(() => StringCalculator.StringCalculator.Add(number));
        }

        [Fact]
        public void Add_NegativeNumbers_ArgumentException()
        {
            //Arrange
            string number = "-3,7";
            //Act
            //Assert
            Assert.Throws<ArgumentException>("-3",() => StringCalculator.StringCalculator.Add(number));
        }

        [Fact]
        public void Add_MoreThanTwoNumbers_Exception()
        {
            //Arrange
            string number = "3,7,4,2";            
            //Act
            //Assert
            Assert.Throws<Exception>(() => StringCalculator.StringCalculator.Add(number));
        }
    }
}
